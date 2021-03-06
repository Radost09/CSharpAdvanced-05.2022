using System;
using System.Collections.Generic;
using System.Text;

namespace CustomDataStuctures
{
    public class CustomList
    {
        private const int InitialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            this.items = new int[InitialCapacity];
        }
        public int this[int index]
        {
            get
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if(index >= this.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }
        public int[] Items { get; set; }
        public int Count { get; private set; }
        public int Indexes { get; set; }

        private void Resize()
        {
            int[] copy = new int[this.items.Length * 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
        public void Add(int number)
        {
            if(this.Count == this.items.Length)
            {
                this.Resize();
            }
            this.items[this.Count] = number;
            this.Count++;
        }
        public int RemoveAt(int index)
        {
            if(index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            var item = this.items[index];
            this.items[index] = default(int);
            this.Shift(index);

            this.Count--;

            if(this.Count <= this.items.Length / 4)
            {
                this.Shrink();
            }
            return item;
        }

        private void Shift(int index)
        {
            for (int i = index; i < this.Count - 1; i++)
            {
                this.items[i] = this.items[i + 1];
            }
        }

        public void Shrink()
        {
            int[] copy = new int[this.items.Length / 2];

            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }
    }
}
