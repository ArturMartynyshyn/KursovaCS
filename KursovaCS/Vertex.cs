namespace KursovaCS;

public struct Vertex
{
    public double X { get; set; }

    public double Y { get; set; }
    
    public Vertex(double x, double y)

    {
        X = x;
        Y = y;
    }

    public static Vertex operator +(Vertex a, Vertex b)

    {
        return new Vertex(a.X + b.X, a.Y + b.Y);
    }



    public static Vertex operator -(Vertex a, Vertex b)

    {
        return new Vertex(a.X - b.X, a.Y - b.Y);
    }

    public static Vertex operator *(Vertex v, double scalar)

    {
        return new Vertex(v.X * scalar, v.Y * scalar);
    }
    
    public static Vertex operator *(double scalar, Vertex v)

    {
        return new Vertex(v.X * scalar, v.Y * scalar);
    }
    
    public static Vertex operator /(Vertex v, double scalar)
    {
        if (scalar == 0)
            throw new DivideByZeroException("Cannot divide a Vertex by zero.");
        return new Vertex(v.X / scalar, v.Y / scalar);

    }

    public override string ToString()

    {
        return $"({X}, {Y})";
    }

}