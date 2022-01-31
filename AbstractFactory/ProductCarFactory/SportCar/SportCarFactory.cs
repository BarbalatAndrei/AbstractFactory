using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.SportCar
{
    public class SportCarFactory : IProductCarFactory
    {
        public IConsumption GetConsumption()
        {
            return new MaxConsumption();
        }

        public IEngine GetEngine()
        {
            return new SportEngine();
        }

        public IWheelDrive GetWheelDrive()
        {
            return new SportWheelDriveType();
        }
    }
}
