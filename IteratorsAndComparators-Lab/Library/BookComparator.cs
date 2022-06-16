using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : Comparer<Book>
    {
        public override int Compare(Book bookOne, Book bookTwo)
        {
            
            //if(result == 0)
            //{
            //    result = bookTwo.Year.CompareTo(bookTwo.Year);
            //}
            return bookOne.Title.CompareTo(bookTwo.Title);
        }
    }
}
