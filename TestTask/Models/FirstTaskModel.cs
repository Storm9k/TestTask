using System;
using System.Collections.Generic;

namespace TestTask
{
    public class FirstTaskModel : ITask<int>, IDisposable
    {
        //Создаем объект и ренерируем псевдослучайные числа в массив
        public FirstTaskModel()
        {
            Random rand = new Random();
            //С помощью цикла for заполняем массив псевдослучаными числами и параллельно добавляяем нечетные числа в список
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
                if (!(array[i] % 2 == 0))
                    OddNumbers.Add(array[i]);
            }
        }

        public int[] array = new int[10];
        List<int> OddNumbers = new List<int>();

        //Реализация интерфейса ITask<T> и возврат результата данной модели
        public int Result()
        {
            int sum = 0;
            //Суммируем каждое второе нечетное число
            for (int i = 1; i < OddNumbers.Count; i += 2)
                sum += Math.Abs(OddNumbers[i]);
            return sum;
        }
        public void Dispose()
        {

        }
    }
}
