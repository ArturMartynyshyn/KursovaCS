namespace KursovaCS;

using System;

public class MyIterator
{
    private readonly FigureContainer container;
    private int position;

    public MyIterator(FigureContainer container, int position)
    {
        this.container = container;
        this.position = position;
    }

    public Figure Current => container[position];

    public static bool operator ==(MyIterator a, MyIterator b)
    {
        return a.container == b.container && a.position == b.position;
    }

    public static bool operator !=(MyIterator a, MyIterator b)
    {
        return !(a == b);
    }

    public static MyIterator operator ++(MyIterator iterator)
    {
        iterator.position++;
        return iterator;
    }
    
    public override bool Equals(object obj)
    {
        return obj is MyIterator other && this == other;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(container, position);
    }
}