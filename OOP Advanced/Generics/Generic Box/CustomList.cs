namespace Generic_Box
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Collections;

    public class CustomList<T>:IEnumerable<T>
        where T: IComparable<T>
    {  
        private List<T> data;

        public CustomList()
        {
            this.data = new List<T>();
        }

        public void Add(T element)
        {
            this.data.Add(element);
        }

        public T Remove(int index)
        {
            var removed = this.data[index];
            this.data.RemoveAt(index);
            return removed;
        }

        public bool Contains(T element)
        {
            if (this.data.Contains(element))
            {
                return true;
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            T firstElement = this.data[firstIndex];
            T secondElement = this.data[secondIndex];

            this.data[firstIndex] = secondElement;
            this.data[secondIndex] = firstElement;
        }

        public int CountGreaterThan(T element)
        {
            var count = 0;

            foreach (var item in this.data)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public T Max()
        {
            return this.data.Max();
        }

        public T Min()
        {
            return this.data.Min();
        }

        public List<T> GetData()
        {
            return this.data;
        }

        public string Print()
        {
            var sb = new StringBuilder();
            this.data.ForEach(x=>sb.AppendLine(x.ToString()));
            
            return sb.ToString().Trim();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
