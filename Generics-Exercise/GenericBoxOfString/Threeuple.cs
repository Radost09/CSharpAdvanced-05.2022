using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Threeuple<Tfirst, Tsecond, Tthird>
    {
        public Threeuple(Tfirst firstElmnt, Tsecond secondElmnt, Tthird thirdElmnt)
        {
            FirstElmnt = firstElmnt;
            SecondElmnt = secondElmnt;
            ThirdElmnt = thirdElmnt;
        }

        public Tfirst FirstElmnt { get; set; }
        public Tsecond SecondElmnt { get; set; }
        public Tthird ThirdElmnt { get; set; }

        public override string ToString()
        {
            return $"{FirstElmnt} -> {SecondElmnt} -> {ThirdElmnt}";
        }
    }
}
