namespace KursovaCS;
using System;

public class Square : MyRectangle
{
    public Square() : base() 
    {
    }

    public Square(Vertex[] initialVertices) : base(initialVertices)
    { 
        if (!IsValidSquare())
        {
            throw new ArgumentException("Надані вершини утворюють прямокутник, але не квадрат.", nameof(initialVertices));
        }
    }

    public override string FigureType => "Square";

    public override double CalculateArea()
    {
        double side = Math.Sqrt(Math.Pow(Vertices[1].X - Vertices[0].X, 2) + Math.Pow(Vertices[1].Y - Vertices[0].Y, 2));
        return side * side;
    }

    public override string ToString()
    {
        return base.ToString().Replace("Rectangle", "Square");
    }
    
    private bool IsValidSquare()
    {
        double dist(Vertex a, Vertex b) => Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));

        double side1 = dist(Vertices[0], Vertices[1]);
        double side2 = dist(Vertices[1], Vertices[2]);
        
        const double epsilon = 1e-9;
        
        return Math.Abs(side1 - side2) < epsilon;
    }
}