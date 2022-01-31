using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.StandardCar
{
    public class AverageConsumption : IConsumption
    {
        private string typeConsumtion;
        public void selectedTypeConsumtpion()
        {
            typeConsumtion = "Standard/Average";
            Console.WriteLine("Is selectet <{0}> Type Consumtion", getTypeConsumtion());
        }
        public string getTypeConsumtion()
        {
            return this.typeConsumtion;
        }
    }
}
