namespace Iterator_Tests
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class ListyIterator<T> : IEnumerable<T>
    {
        private readonly List<T> collection;
        private int currentIndex = 0;

        public ListyIterator(params T[] collection)
        {
            this.collection = new List<T>(collection);
        }

        public int Count => this.collection.Count;

        public int CurrentIndex => this.currentIndex;

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

        public T Print()
        {
            if (this.collection.Count == 0)
            {
                throw new ArgumentException("Invalid Operation!");
            }

            return this.collection[this.currentIndex];
        }

        public string PrintAll()
        {
            var sb = new StringBuilder();
            foreach (var item in this.collection)
            {
                sb.Append($"{item} ");
            }

            return sb.ToString().Trim();
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
