using System;
using System.Reflection;

namespace _22_Tech_Interview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stack<int> myStack = new Stack<int>(10);
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());
            Console.WriteLine(myStack.Pop());

        }
    }
    //LIFO
    //Push
    //Pop
    //Peek
    //Generic
    class Stack<T>
    {
        T[] arr;
        int pointer = 0;
        public Stack(int size)
        {
           this.arr = new T[size];
        }
        public void Push(T data)
        {
            arr[pointer++] = data;
        }
        public T Pop()
        {
            return arr[--pointer];
        }
        public T Peek()
        {
            return arr[pointer-1];
        }
    }
}
