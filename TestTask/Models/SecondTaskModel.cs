using System;
using System.Collections.Generic;

namespace TestTask
{
    public class SecondTaskModel : ITask <LinkedList<int>>, IDisposable
    {
        public LinkedList<int> FirstLL = new LinkedList<int>();
        public LinkedList<int> SecondLL = new LinkedList<int>();
        private int Length = 5;

        //Создаем объект и ренерируем псевдослучайные числа в два связанных списка
        public SecondTaskModel()
        {
            Random random = new Random();
            for (int i = 0; i < Length; i++)
            {
                FirstLL.AddFirst(random.Next(0, 10));
                SecondLL.AddFirst(random.Next(0, 10));
            }
        }

        //Реализация интерфейса ITask<T> и возврат результата данной модели
        public LinkedList<int> Result()
        {
            //Создаем промежуточный связанный список с результатами сложения, а так же объекты нод со ссылкой на первый элемент в связанном свписке
            LinkedList<int> Result = new LinkedList<int>();
            LinkedListNode<int> ResultNode = Result.AddFirst(0);
            LinkedListNode<int> firstNodes = FirstLL.First;
            LinkedListNode<int> secondNodes = SecondLL.First;
            //Цикл для поузлового сложения и добавления результата в промежуточный связанный список
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
