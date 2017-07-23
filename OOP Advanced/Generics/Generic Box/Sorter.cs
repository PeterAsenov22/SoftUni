namespace Generic_Box
{
    using System;

    public static class Sorter<T>
        where T : IComparable<T>

    {
        public static void Sort(CustomList<T> list)
        {
            list.GetData().Sort();
        }
    }
}
