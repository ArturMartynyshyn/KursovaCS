namespace KursovaCS;

using System;
using System.Text;

public class MyRectangle : Figure
{
    public MyRectangle() : base(4)
    {
    }

    public MyRectangle(Vertex[] initialVertices) : base(initialVertices)
    {
        if (initialVertices == null || initialVertices.Length != 4)
        {
            throw new ArgumentException("Для створення прямокутника потрібно рівно 4 вершини.", nameof(initialVertices));
        }
        if (!IsValid())
        {
            throw new ArgumentException("Надані вершини не утворюють правильний прямокутник.", nameof(initialVertices));
        }
    }

    public override string FigureType => "Rectangle";

    public override void Move(double dx, double dy)
    {
        var offset = new Vertex(dx, dy);
        for (int i = 0; i < Vertices.Length; i++)
        {
            Vertices[i] += offset;
        }
    }

    public override double CalculateArea()
    {
        double width = Math.Sqrt(Math.Pow(Vertices[1].X - Vertices[0].X, 2) + Math.Pow(Vertices[1].Y - Vertices[0].Y, 2));
        double height = Math.Sqrt(Math.Pow(Vertices[3].X - Vertices[0].X, 2) + Math.Pow(Vertices[3].Y - Vertices[0].Y, 2));
        return width * height;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("Rectangle: ");
        foreach (var v in Vertices)
        {
            sb.Append(v).Append(" ");
        }
        return sb.ToString().Trim();
    }
    
    public bool IsValid()
    {
        double dist(Vertex a, Vertex b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

        if (Vertices == null || Vertices.Length != 4)
        {
            return false;
        }

        double sideAB = dist(Vertices[0], Vertices[1]);
        double sideBC = dist(Vertices[1], Vertices[2]);
        double sideCD = dist(Vertices[2], Vertices[3]);
        double sideDA = dist(Vertices[3], Vertices[0]);
        
        double diagAC = dist(Vertices[0], Vertices[2]);
        double diagBD = dist(Vertices[1], Vertices[3]);

        const double epsilon = 1e-9;

        bool oppositeSidesEqual = Math.Abs(sideAB - sideCD) < epsilon && Math.Abs(sideBC - sideDA) < epsilon;
        bool diagonalsEqual = Math.Abs(diagAC - diagBD) < epsilon;

        return oppositeSidesEqual && diagonalsEqual;
    }
}