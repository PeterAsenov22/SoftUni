using System.Collections.Generic;

public class BookComparator:IComparer<Book>
{
    public int Compare(Book x, Book y)
    {
        var titleCompare = x.Title.CompareTo(y.Title);
        if (titleCompare != 0)
        {
            return titleCompare;
        }

        return y.Year.CompareTo(x.Year);
    }
}
