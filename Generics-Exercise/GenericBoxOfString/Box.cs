using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value.GetType()}: {Value}";
        }

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }
        //public Box(T element)
        //{
        //    Element = element;
        //}
        //public Box(List<T> elementsList)
        //{
        //    Elements = elementsList;
        //}
        //public T Element { get; }
        //public List<T> Elements { get; }

        //public void Swap(List<T> elements, int indexOne, int indexTwo)
        //{
        //    T firstElement = elements[indexOne];
        //    elements[indexOne] = elements[indexTwo];
        //    elements[indexTwo] = firstElement;
        //}

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    foreach (T element in Elements)
        //    {
        //        sb.AppendLine($"{element.GetType()}: {element}");
        //    }
        //    return sb.ToString().TrimEnd();
        //    //return $"{typeof(T)}: {Element}";
        //}
    }
}
