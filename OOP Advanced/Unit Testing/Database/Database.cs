namespace Database
{
    using System;
    using System.Collections.Generic;

    public class Database
    {
        private const int DefaultCapacity = 16;
        private List<int> collection;

        public Database(params int[] elements)
        {
            this.collection = new List<int>(DefaultCapacity);

            for (int i = 0; i < elements.Length; i++)
            {
                this.Add(elements[i]);
            }
        }

        public int Count => this.collection.Count;

        public int Capacity => this.collection.Capacity;

        public void Add(int element)
        {
            if (this.collection.Count == 16)
            {
                throw new InvalidOperationException("Cannot add more elements in the collection.");
            }

            this.collection.Add(element);
        }

        public void Remove()
        {
            if (this.collection.Count == 0)
            {
                throw new InvalidOperationException("Cannot remove element from empty database!");
            }

            this.collection.RemoveAt(this.collection.Count-1);
        }

        public int[] Fetch()
        {
            return this.collection.ToArray();
        }
    }
}
