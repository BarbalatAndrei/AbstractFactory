using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface ISportCarProd
    {
        public void SportCarProductFunction();
        public SportProduct getCategoryCar();
    }

    public interface CopyOfISportCarProd
    {
        public void SportCarProductFunction();
        public SportProduct getCategoryCar();
    }
}
