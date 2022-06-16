using System;

namespace CustomDoublyLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var linkedList = new DoublyLinkedList();

            linkedList.AddHead(1);
            linkedList.AddHead(2);
            linkedList.AddHead(3);
            linkedList.AddTail(4);
            linkedList.AddTail(5);

            linkedList.ForEach(n => Console.WriteLine(n));
            var array = linkedList.ToArray();

            Console.WriteLine($"Head: {linkedList.Head.Value}");
            Console.WriteLine($"Tail: {linkedList.Tail.Value}");
            Console.WriteLine($"Next to Head: {linkedList.Head.NextNode.Value}");

            var removedHead = linkedList.RemoveHead();
            Console.WriteLine($"Removed Head {removedHead}");
            Console.WriteLine($"Head after removal {linkedList.Head.Value}");

            var removedTail = linkedList.RemoveTail();
            Console.WriteLine($"Removed Tail {removedTail}");
            Console.WriteLine($"Tail after removal {linkedList.Tail.Value}");
        }
    }
}
