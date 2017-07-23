using System.Collections.Generic;
using System.Linq;

public class Box<T> : IBox<T>
{
    private IList<T> elements;

    public Box()
    {
        this.elements = new List<T>();
    }

    public void Add(T element)
    {
        this.elements.Add(element);
    }

    public T Remove()
    {
        var removed = this.elements.LastOrDefault();
        this.elements.RemoveAt(this.Count - 1);
        return removed;
    }

    public int Count => this.elements.Count;
}
