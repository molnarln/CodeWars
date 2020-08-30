using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class CustomStack<T>
    {
        int capacity;
        T[] stack;
        int top;
        public CustomStack(int MaxElements)
        {
            capacity = MaxElements;
            stack = new T[capacity];

        }
        public int push(T Element)
        {

            if (top == capacity - 1)
            {


                return -1;
            }
            else
            {

                top = top + 1;
                stack[top] = Element;
            }

            return 0;
        }
        public T pop()
        {
            T RemovedElement;
            T temp = default(T);
 
            if (!(top <= 0))
            {
                RemovedElement = stack[top];
                top = top - 1;
                return RemovedElement;
            }
            return temp;
        }

        public bool isEmpty()
        {
            if (stack.Length == 0)
            {
                return true;
            }
            return false;
        }
        public int Size()
        {
            return stack.Length;
        }
        public void Clear()
        {
            Array.Clear(this.stack, 0, this.stack.Length);
        }
    }
}
