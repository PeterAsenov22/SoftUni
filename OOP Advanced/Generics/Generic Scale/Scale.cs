using System;

public class Scale<T>
    where T : IComparable<T>
{
    private T Left { get; set; }

    private T Right { get; set; }

    public Scale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public T GetHeavier()
    {
        if (this.Left.CompareTo(this.Right) > 0)
        {
            return this.Left;
        }
        else if (this.Left.CompareTo(this.Right) < 0)
        {
            return this.Right;
        }

        return default(T);
    }
}
