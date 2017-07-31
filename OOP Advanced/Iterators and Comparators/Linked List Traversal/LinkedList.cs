namespace Linked_List_Traversal
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class LinkedList<T> : IEnumerable<T> where T : IComparable
    {
        private class ListNode<T>
        {
            public T Value { get; private set; }

            public ListNode<T> NextNode { get; set; }

            public ListNode(T value)
            {
                this.Value = value;
            }
        }

        public LinkedList()
        {
            this.Head = null;
            this.Count = 0;
        }

        private ListNode<T> Head { get; set; }

        public int Count { get; private set; }

        public void Add(T item)
        {
            if (this.Count == 0)
            {
                this.Head = new ListNode<T>(item);
            }
            else
            {
                ListNode<T> lastNode = GetElementAtIndex(this.Count - 1);
                lastNode.NextNode = new ListNode<T>(item);
            }

            this.Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var currentNode = this.Head;

            while (currentNode != null)
            {
                yield return currentNode.Value;

                currentNode = currentNode.NextNode;
            }
        }

        public T Remove(int index)
        {
            var removeValue = default(T);

            if (index == 0)
            {
                removeValue = this.Head.Value;
                this.Head = this.Head.NextNode;
            }
            else
            {
                ListNode<T> prevNode = this.GetElementAtIndex(index - 1);
                ListNode<T> currentNode = this.GetElementAtIndex(index);
                prevNode.NextNode = currentNode.NextNode;

                removeValue = currentNode.Value;
            }

            this.Count--;

            return removeValue;
        }

        public int FirstIndexOf(T element)
        {
            int firstIndex = IndexOf(element, true);
            return firstIndex;
        }

        public int LastIndexOf(T element)
        {
            int lastIndex = IndexOf(element, false);
            return lastIndex;
        }

        private int IndexOf(T element, bool isFirstFoundIndexNeeded)
        {
            int foundIndex = -1;
            var currentNode = this.Head;
            for (int index = 0; index < this.Count; index++)
            {
                if (currentNode.Value.Equals(element))
                {
                    foundIndex = index;
                    if (isFirstFoundIndexNeeded)
                    {
                        return foundIndex;
                    }
                }

                currentNode = currentNode.NextNode;
            }

            return foundIndex;
        }

        private ListNode<T> GetElementAtIndex(int index)
        {
            var currentElement = this.Head;
            for (int i = 0; i < index; i++)
            {
                currentElement = currentElement.NextNode;
            }

            return currentElement;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
