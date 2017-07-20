using System.Collections.Generic;
using System.Linq;

public class AddRemoveCollection<T>:IAddRemoveCollection<T>
{
    private List<T> items = new List<T>(100);

    public int Add(T element)
    {
        items.Insert(0, element);
        return 0;
    }

    public T Remove()
    {
        var last = items.LastOrDefault();
        items.RemoveAt(items.Count - 1);
        return last;
    }
}
