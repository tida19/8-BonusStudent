using System;
using System.Collections.Generic;

namespace _2_StackExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
                stack.Push(i);

            stack.Clear();

            for (int i = ini; i <= max; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
    public class Stack
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null object to the stack");

            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no element in the stack yet");
            var index = _list.Count - 1;

            var toReturn = _list[index];

            _list.RemoveAt(index);

            return (toReturn);
        }
        public void Clear()
        {
            _list.Clear();
        }
    }
}
