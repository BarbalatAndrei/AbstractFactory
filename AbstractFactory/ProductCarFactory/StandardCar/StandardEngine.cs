using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.StandardCar
{
    public class StandardEngine : IEngine
    {
        private string typeEngine;
        public void selectedTypeEngine()
        {
            typeEngine = "Standard";
            Console.WriteLine("Is selectet <{0}> Engine Type", getTypeEngine());
        }

        public string getTypeEngine()
        {
            return this.typeEngine;
        }
    }
}
