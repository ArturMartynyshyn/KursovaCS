namespace KursovaCS;

using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

public class FigureContainer : IDisposable
{
    private readonly List<Figure> figures = new List<Figure>();
    private bool disposed = false;

    public void AddFigure(Figure figure)
    {
        if (figure != null)
        {
            figures.Add(figure);
        }
    }
    
    public void RemoveById(int id)
    {
        if (id >= 0 && id < figures.Count)
        {
            figures.RemoveAt(id);
        }
        else
        {
            throw new ArgumentOutOfRangeException("id", "Недійсний індекс фігури.");
        }
    }

    public int Count => figures.Count;
    public Figure this[int index] => figures[index];
    
    public MyIterator Begin()
    {
        return new MyIterator(this, 0);
    }

    public MyIterator End()
    {
        return new MyIterator(this, figures.Count);
    }
    
    public Figure GetMaxAreaFigure()
    {
        if (Count == 0)
        {
            return null;
        }

        MyIterator it = Begin();
        Figure maxFigure = it.Current;
        
        for (++it; it != End(); ++it)
        {
            if (it.Current.CalculateArea() > maxFigure.CalculateArea())
            {
                maxFigure = it.Current;
            }
        }
        return maxFigure;
    }
    
    public void MoveFigureByIndex(int index, double dx, double dy)
    {
        int i = 0;
        for (MyIterator it = Begin(); it != End(); ++it, i++)
        {
            if (i == index) 
            it.Current.Move(dx, dy);
        }
    }
    
    public Figure GetFigure(int index)
    {
        if (index < 0 || index >= figures.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index), "Недійсний індекс фігури.");
        }
        return figures[index];
    }

    public void SaveToFile(string filename)
    {
        using (var writer = new StreamWriter(filename))
        {
            for (MyIterator it = Begin(); it != End(); ++it)
            {
                var fig = it.Current;
                writer.Write(FormattableString.Invariant($"{fig.FigureType} "));
                var vertices = fig.GetVertices();
                foreach (var v in vertices)
                {
                    writer.Write(FormattableString.Invariant($"{v.X} {v.Y} "));
                }
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.Error.WriteLine($"Не вдалося відкрити файл для читання: {filename}");
            return;
        }
        
        var lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            if (string.IsNullOrWhiteSpace(line)) continue;

            var parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < 9) continue;

            string figureType = parts[0];
            var vertices = new Vertex[4];
            
            try
            {
                for (int i = 0; i < 4; i++)
                {
                    double x = double.Parse(parts[1 + i * 2], CultureInfo.InvariantCulture);
                    double y = double.Parse(parts[2 + i * 2], CultureInfo.InvariantCulture);
                    vertices[i] = new Vertex(x, y);
                }

                switch (figureType)
                {
                    case "Square":
                        AddFigure(new Square(vertices));
                        break;
                    case "Rectangle":
                        AddFigure(new MyRectangle(vertices));
                        break;
                    default:
                        Console.Error.WriteLine($"Невідомий тип фігури: {figureType}");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.Error.WriteLine($"Помилка завантаження фігури: {ex.Message} Дані проігноровано.");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Помилка формату координат у файлі. Дані проігноровано.");
            }
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;
        if (disposing)
        {
            for (MyIterator it = Begin(); it != End(); ++it)
            {
                it.Current.Dispose();
            }
        }
        disposed = true;
    }
}