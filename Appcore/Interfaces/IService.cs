using System;
using System.Collections.Generic;

namespace Appcore
{
    public interface IService<T>
    {

        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();

    }
}
