using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList
    {
        public int Count { get; private set; }

        public ListNode Head { get; private set; }
        public ListNode Tail { get; private set; }

        public bool isEmpty => this.Count == 0;

        public void AddHead(int value)
        {
            if(this.isEmpty)
            {
                this.Head = this.Tail = new ListNode(value);
            }
            else
            {
                var previousHead = this.Head;
                var newNode = new ListNode(value);
                previousHead.PreviousNode = newNode;
                newNode.NextNode = previousHead;
                this.Head = newNode;
            }
            this.Count++;
        }

        public void AddTail(int value)
        {
            if (this.isEmpty)
            {
                this.Head = this.Tail = new ListNode(value);
            }
            else
            {
                var previousTail = this.Tail;
                var newNode = new ListNode(value);
                newNode.PreviousNode = previousTail;
                previousTail.NextNode = newNode;
                this.Tail = newNode;
            }
            Count++;
        }
        public int RemoveHead()
        {
            if(this.isEmpty)
            {
                throw new InvalidOperationException($"List is empty");
            }
            var removedHead = this.Head;
            var removedHeadValue = removedHead.Value;
            var nextHead = removedHead.NextNode;

            if(nextHead == null)
            {
                this.Head = this.Tail = null;
            }
            else
            {
                nextHead.PreviousNode = null;
                removedHead.NextNode = null;
                this.Head = nextHead;
            }
            this.Count--;
            return removedHeadValue;
        }
        public int RemoveTail()
        {
            if (this.isEmpty)
            {
                throw new InvalidOperationException($"List is empty");
            }
            var removedTail = this.Tail;
            var removedTailValue = removedTail.Value;
            var nextTail = removedTail.PreviousNode;

            if(nextTail == null)
            {
                this.Tail = this.Head = null;
            }
            else
            {
                nextTail.PreviousNode = null;
                removedTail.NextNode = null;
                this.Tail = nextTail;
            }
            this.Count--;
            return removedTailValue;
        }

        public void ForEach(Action<int> action)
        {
            var currentNode = this.Head;
            while(currentNode != null)
            {
                action(currentNode.Value);
                currentNode = currentNode.NextNode;
            }
        }

        public List<int> ToList()
        {
            var list = new List<int>();

            this.ForEach(n => list.Add(n));

            return list;
        }

        public int[] ToArray()
        {
            var array = new int[this.Count];
            int counter = 0;
            //this.ForEach(number => array[counter] = number);
            //counter++;

            var currentNode = this.Head;
            while(currentNode != null)
            {
                array[counter] = currentNode.Value;
                counter++;
                currentNode = currentNode.NextNode;
            }

            return array;
        }

        public class ListNode
        {
            public ListNode(int value)
            {
                this.Value = value;
            }
            public int Value { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode PreviousNode { get; set; }
            
        }
    }
    
}
