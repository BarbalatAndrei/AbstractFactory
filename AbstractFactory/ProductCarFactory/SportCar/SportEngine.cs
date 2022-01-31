using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.SportCar
{
    public class SportEngine : IEngine
    {
        private string typeEngine;
        public void selectedTypeEngine()
        {
            this.typeEngine = "Sport";
            Console.WriteLine("Is selected <{0}> Engine Type", getTypeEngine());
        }

        public string getTypeEngine()
        {
            return this.typeEngine;
        }
    }
}
