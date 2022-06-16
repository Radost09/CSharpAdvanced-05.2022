using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        private int currentIndex;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }
        public IEnumerator<Book> GetEnumerator()
        {
            var booksList = this.books.ToList();
            for (int i = 0; i < booksList.Count; i++)
            {
                yield return booksList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }
            public Book Current => this.books[currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose() { }

            public bool MoveNext() => ++this.currentIndex < this.books.Count;

            public void Reset() => this.currentIndex = -1;
        }
    }
}
