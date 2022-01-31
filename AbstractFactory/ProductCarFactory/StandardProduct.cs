using AbstractFactory.Prototype;
using AbstractFactory.StandardCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public class StandardProduct : IStandardCarProd, IPrototype
    {
        public IEngine engine;
        public IConsumption consumption;
        public IWheelDrive wheelDrive;

        public StandardProduct()
        {
            IProductCarFactory carFactory = new StandardCarFactory();
            this.engine = carFactory.GetEngine();
            this.consumption = carFactory.GetConsumption();
            this.wheelDrive = carFactory.GetWheelDrive();
        }
        public void StandardCarProductFunction()
        {
            Console.WriteLine("Build product...");
            this.engine.selectedTypeEngine();
            this.consumption.selectedTypeConsumtpion();
            this.wheelDrive.selectedTypeWheelDrive();

            Console.WriteLine("================================");
        }
        public StandardProduct getCategoryCar()
        {
            return this;
        }

        public IPrototype GetPrototype()
        {
            return (IPrototype)this.MemberwiseClone();
        }


    }
}
