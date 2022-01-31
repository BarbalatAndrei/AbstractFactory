using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface IStandardCarProd
    {
        public void StandardCarProductFunction();
        public StandardProduct getCategoryCar();
    }

    public interface CopyOfIStandardCarProd
    {
        public void StandardCarProductFunction();
        public StandardProduct getCategoryCar();
    }
}
