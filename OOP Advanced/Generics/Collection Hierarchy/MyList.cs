using System.Collections.Generic;
using System.Linq;

public class MyList<T>:IMyList<T>
{
    private List<T> items;

    public MyList()
    {
        this.items = new List<T>();
    }

    public int Add(T element)
    {
        items.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        var first = items.FirstOrDefault();
        items.RemoveAt(0);
        return first;
    }

    public int Used => items.Count;
}
