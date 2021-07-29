using System;

namespace TestTask.Models
{
    public class ThirdTask : ITask <bool>
    {
        private string UserInput;

        public string userinput
        {
            get { return UserInput; }
            set { if (!String.IsNullOrEmpty(value)) UserInput = value; }
        }

        public ThirdTask()
        {

        }

        public ThirdTask (string ui)
        {
            UserInput = ui;
        }

        //Реализация интерфейса ITask<T> и возврат результата данной модели
        public bool Result ()
        {
                string tmpUI;
                int middleindex = UserInput.Length / 2;
                if (UserInput.Length % 2 != 0)
                    middleindex += 1;
                char[] strReverse = new char[UserInput.Length / 2];
                UserInput.CopyTo(middleindex, strReverse, 0, UserInput.Length / 2);
                Array.Reverse(strReverse);
                tmpUI = new string(strReverse);
            return String.Equals(UserInput.Substring(0, UserInput.Length / 2), tmpUI);
        }

        public void Dispose()
        {
            
        }
    }
}
