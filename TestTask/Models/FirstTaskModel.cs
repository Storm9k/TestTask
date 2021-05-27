using System;
using System.Collections.Generic;

namespace TestTask
{
    public class FirstTaskModel : ITask<int>, IDisposable
    {

        public FirstTaskModel()
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                if (!(array[i] % 2 == 0))
                    OddNumbers.Add(array[i]);
            }
        }

        public int[] array = new int[10];
        List<int> OddNumbers = new List<int>();
        public int Result()
        {
            int sum = 0;
            for (int i = 1; i < OddNumbers.Count; i += 2)
                sum += Math.Abs(OddNumbers[i]);
            return sum;
        }
        public void Dispose()
        {

        }
    }
}
