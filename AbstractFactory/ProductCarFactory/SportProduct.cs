using AbstractFactory.Prototype;
using AbstractFactory.SportCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public class SportProduct : ISportCarProd, IPrototype
    {
        public IEngine engine;
        public IConsumption consumption;
        public IWheelDrive wheelDrive;

        public SportProduct()
        {
            IProductCarFactory carFactory = new SportCarFactory();
            this.engine = carFactory.GetEngine();
            this.consumption = carFactory.GetConsumption();
            this.wheelDrive = carFactory.GetWheelDrive();
        }

        public void SportCarProductFunction()
        {
            Console.WriteLine("Build product...");
            this.engine.selectedTypeEngine();
            this.consumption.selectedTypeConsumtpion();
            this.wheelDrive.selectedTypeWheelDrive();

            Console.WriteLine("================================");
        }

        public SportProduct getCategoryCar()
        {
            return this;
        }

        public IPrototype GetPrototype()
        {
            return (IPrototype)this.MemberwiseClone();
        }


    }
}
