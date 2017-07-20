using System.Collections.Generic;
using System.Linq;

public class MyList<T>:IMyList<T>
{
    private List<T> items = new List<T>(100);

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
