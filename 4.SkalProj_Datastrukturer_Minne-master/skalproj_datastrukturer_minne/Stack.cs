using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Stack
    {
        private Stack<string> TheStack = new Stack<string>();

        public Stack()
        {
        }

        public void AddToQueue(string item)
        {
            TheStack.Push(item);
        }

        public string DeQueue()
        {
            return TheStack.Pop();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var separator = string.Empty;
            for(var i = TheStack.Count - 1; i >= 0; i--)
            {
                sb.Append(separator + TheStack.ElementAt(i));
                separator = "->";
            }
            return sb.ToString();
        }

        public string ReverseText(string textToReverse)
        {
            var sb = new StringBuilder();

            var stack = new Stack<char>(textToReverse.ToCharArray());
            foreach(var item in stack)
            {
                sb.Append(item);
            }

            return sb.ToString();
        }
    }
}
