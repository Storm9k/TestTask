using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask
{
    public class SecondTaskModel : ITask <int>
    {
        public int Result()
        {
            return 0;
        }
    }
}
