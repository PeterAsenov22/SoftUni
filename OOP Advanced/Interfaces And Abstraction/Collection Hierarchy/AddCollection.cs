using System.Collections.Generic;

public class AddCollection<T>:IAddCollection<T>
{
    private List<T> items = new List<T>(100);

    public int Add(T element)
    {
        items.Add(element);
        return items.Count-1;
    }        
}
