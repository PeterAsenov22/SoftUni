namespace ListyIterator
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ListIterator<T>:IEnumerable<T>
    {
        private readonly List<T> collection;
        private int currentIndex = 0;

        public ListIterator(params T[] collection)
        {
            this.collection = new List<T>(collection);
        }

        public bool Move()
        {
            if (this.HasNext())
            {
                currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext() => currentIndex + 1 < this.collection.Count;

        public void Print()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            Console.WriteLine(this.collection[this.currentIndex]);
        }

        public void PrintAll()
        {
            var sb = new StringBuilder();
            foreach (var item in this.collection)
            {
                sb.Append($"{item} ");
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.collection.Count; i++)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
