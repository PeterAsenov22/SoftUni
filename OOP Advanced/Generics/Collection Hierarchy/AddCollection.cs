using System.Collections.Generic;

public class AddCollection<T>:IAddCollection<T>
{
    private List<T> items;

    public AddCollection()
    {
        this.items = new List<T>();
    }

    public int Add(T element)
    {
        items.Add(element);
        return items.Count-1;
    }        
}
