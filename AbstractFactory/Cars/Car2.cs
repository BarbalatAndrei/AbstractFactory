using AbstractFactory.Cars.Car_Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Cars
{
    public class Car2
    {
        public Engine engine = new Engine()
        {
            _capacity = "1.3",
            _model = "V2",
        };

        public Consumtion consumtion = new Consumtion()
        {
            maxConsumtion = "7 L",
            average = "3.5 L",
        };

        public WheelDrive wheelDrive = new WheelDrive()
        {
            wheelDrive = "Back Wheel Drive",
        };
    }
}
