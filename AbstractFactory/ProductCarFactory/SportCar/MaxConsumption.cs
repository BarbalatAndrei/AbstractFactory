using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.SportCar
{
    public class MaxConsumption : IConsumption
    {
        private string typeConsumtion;
        public void selectedTypeConsumtpion()
        {
            typeConsumtion = "Sport";
            Console.WriteLine("Is selectet <{0}> Type Consumtion", getTypeConsumtion());
        }
        public string getTypeConsumtion()
        {
            return this.typeConsumtion;
        }
    }
}
