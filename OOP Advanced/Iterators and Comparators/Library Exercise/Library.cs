﻿using System.Collections;
using System.Collections.Generic;

public class Library:IEnumerable<Book>
{
    private readonly SortedSet<Book> books;

    public Library(params Book[] books)
    {
        this.books = new SortedSet<Book>(books,new BookComparator());
    }

    public IEnumerator<Book> GetEnumerator()
    {
        return new LibraryIterator(this.books);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class LibraryIterator:IEnumerator<Book>
    {
        private int currentIndex;
        private readonly IList<Book> books;

        public LibraryIterator(IEnumerable<Book> books)
        {
            this.books = new List<Book>(books);
            this.Reset();
        }

        public void Dispose()
        {
        }

        public bool MoveNext() => ++this.currentIndex < this.books.Count;

        public void Reset()
        {
            this.currentIndex = -1;
        }

        public Book Current => this.books[this.currentIndex];

        object IEnumerator.Current => this.Current;
    }
}