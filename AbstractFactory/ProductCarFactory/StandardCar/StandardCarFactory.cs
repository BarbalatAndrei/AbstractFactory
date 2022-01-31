using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.StandardCar
{
    public class StandardCarFactory : IProductCarFactory
    {
        public IConsumption GetConsumption()
        {
            return new AverageConsumption();
        }

        public IEngine GetEngine()
        {
            return new StandardEngine();
        }

        public IWheelDrive GetWheelDrive()
        {
            return new StandardWheelDriveType();
        }
    }
}
