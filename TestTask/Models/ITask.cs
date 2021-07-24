using System;

namespace TestTask.Models
{
    public interface ITask <T> : IDisposable
    {
        T Result();

    }
}
