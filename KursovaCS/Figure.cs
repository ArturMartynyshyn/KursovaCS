namespace KursovaCS;

using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Figure : IDisposable
{
    protected Vertex[] Vertices { get; set; }

    private bool disposed = false;
    
    protected Figure(int vertexCount)
    {
        Vertices = new Vertex[vertexCount];
    }
    
    protected Figure(Vertex[] initialVertices)
    {
        if (initialVertices == null)
        {
            Vertices = Array.Empty<Vertex>();
        }
        else
        {
            Vertices = new Vertex[initialVertices.Length];
            Array.Copy(initialVertices, Vertices, initialVertices.Length);
        }
    }
    
    public abstract void Move(double dx, double dy);
    public abstract double CalculateArea();
    public abstract string FigureType { get; }
    
    public abstract override string ToString();
    
    public IReadOnlyList<Vertex> GetVertices()
    {
        return Array.AsReadOnly(Vertices);
    }
    
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed)
        {
            return;
        }

        if (disposing)
        {
        }

        disposed = true;
    }
}