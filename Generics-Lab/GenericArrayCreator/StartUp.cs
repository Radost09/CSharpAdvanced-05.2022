using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var creator = ArrayCreator.Create(10, 5);
            Console.WriteLine(creator);

            var text = ArrayCreator.Create(10, "Radost");
            Console.WriteLine(text);


        }
    }
}
