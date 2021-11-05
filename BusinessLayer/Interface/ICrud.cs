using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface ICrud
    {
        void Add();
        void Edit();
        void Delete();
        T List<T>();
    }
}
