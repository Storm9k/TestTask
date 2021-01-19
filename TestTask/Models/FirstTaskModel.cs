using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask
{
    public class FirstTaskModel : ITask<int>, IDisposable
    {

        public FirstTaskModel()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(100);
                if (!(array[i] % 2 == 0))
                    temp.Add(array[i]);
            }
        }

        int sum = 0;
        Random rand = new Random();
        public int[] array = new int[10];
        public List<int> temp = new List<int>();


        public int Result()
        {
            for (int i = 1; i < temp.Count; i += 2)
                sum += temp[i];
            return sum;
        }

        public void Dispose()
        {
            
        }

    }
}
