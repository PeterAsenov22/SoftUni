namespace Stack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Stack<T>:IEnumerable<T>
    {
        private IList<T> collection;

        public Stack()
        {
            this.collection = new List<T>();
        }

        public void Push(T[]elements)
        {
            foreach (var item in elements)
            {
                this.collection.Add(item);
            }
        }

        public void Pop()
        {
            if (this.collection.Count== 0)
            {
                throw new Exception("No elements");
            }

            this.collection.RemoveAt(this.collection.Count-1);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.collection.Count-1; i >=0; i--)
            {
                yield return this.collection[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
