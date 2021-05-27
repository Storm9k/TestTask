using System;
using System.Collections.Generic;

namespace TestTask
{
    public class SecondTaskModel : ITask <LinkedList<int>>, IDisposable
    {
        public LinkedList<int> FirstLL = new LinkedList<int>();
        public LinkedList<int> SecondLL = new LinkedList<int>();
        private int Length = 5;

        public SecondTaskModel()
        {
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                FirstLL.AddFirst(random.Next(0, 10));
                SecondLL.AddFirst(random.Next(0, 10));
            }

        }
        
        public LinkedList<int> Result()
        {
            LinkedList<int> Result = new LinkedList<int>();
            LinkedListNode<int> ResultNode = Result.AddFirst(0);
            LinkedListNode<int> firstNodes = FirstLL.First;
            LinkedListNode<int> secondNodes = SecondLL.First;
            while (firstNodes != null && secondNodes != null)
            {
                ResultNode.Value += firstNodes.Value + secondNodes.Value;
                if ((firstNodes.Next != null && secondNodes.Next != null) || ResultNode.Value >= 10)
                Result.AddLast(0);
                if (ResultNode.Value >= 10)
                {
                    ResultNode.Value %= 10;
                    ResultNode.Next.Value++;
                }
                ResultNode = ResultNode.Next;
                firstNodes = firstNodes.Next;
                secondNodes = secondNodes.Next;
            }
            
            return Result;
        }

        public void Dispose()
        {

        }
    }
}
