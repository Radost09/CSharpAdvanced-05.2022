using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Tuple<Tfirst, Tsecond>
    {
        public Tuple(Tfirst first, Tsecond second)
        {
            FirstElement = first;
            SecondElement = second;
        }

        public Tfirst FirstElement { get; set; }
        public Tsecond SecondElement { get; set; }

        public override string ToString()
        {
            return $"{FirstElement} -> {SecondElement}";
        }
    }
}
