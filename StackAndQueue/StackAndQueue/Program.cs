using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Stack");
            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek(); 
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();
            Console.ReadKey();
        }
    }
}
