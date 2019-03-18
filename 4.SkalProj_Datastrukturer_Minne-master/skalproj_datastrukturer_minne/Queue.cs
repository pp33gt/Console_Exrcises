using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Queue
    {
        private Queue<string> TheQue = new Queue<string>();

        public Queue()
        {
        }

        public void AddToQueue(string item)
        {
            TheQue.Enqueue(item);
        }

        public string DeQueue()
        {
            return TheQue.Dequeue();
        }

        

        public override string ToString()
        {
            var sb = new StringBuilder();
            var separator = string.Empty;
            for(var i = TheQue.Count - 1; i >= 0; i--)
            {
                sb.Append(separator + TheQue.ElementAt(i));
                separator = "->";
            }
            return sb.ToString();
        }
    }
}
