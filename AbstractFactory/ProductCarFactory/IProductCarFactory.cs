using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface IProductCarFactory
    {
        public IEngine GetEngine();
        public IConsumption GetConsumption();
        public IWheelDrive GetWheelDrive();
    }
}
