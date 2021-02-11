﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackConstruct
{
    public class CustomStack
    {
        int initialCapacity = 4;
        int[] array;

        public CustomStack()
        {
           this.array = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public void Push(int element)
        {
            if (this.Count == this.array.Length)
            {
                this.Resize();
            }
            this.array[this.Count] = element;
            this.Count++;
        }

        public int Pop()
        {
            this.ValidateIndex();

            

            if (this.Count <= array.Length / 4)
            {
                this.Shrink();
            }

            int element = this.array[Count - 1];
            this.array[this.Count - 1] = default;
            this.Count--;

            return element;

            
        }

        public int Peek()
        {
            this.ValidateIndex();
            return this.array[this.Count - 1];

        }

        public void ForEach(Action<int> action)
        {
            foreach (int element in this.array)
            {

                if (element == 0)
                {
                    break;
                }
                action(element);
               
            }
        }

        public void MySelect(Func<int, int> func)
        {
            for (int i = 0; i < this.Count; i++)
            {
                int element = this.array[i];
                int a = func(element);
                this.array[i] = a;
            }
        }


        private void ValidateIndex()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
        }

        

        private void Shrink()
        {
            int[] copy = new int[this.array.Length / 2];
            Array.Copy(this.array, copy, this.Count);
            this.array = copy;
        }

        private void Resize()
        {
            int[] copy = new int[this.array.Length * 2];
            Array.Copy(this.array, copy, this.Count);
            this.array = copy;
        }
    }
}
