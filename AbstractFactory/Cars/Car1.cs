using AbstractFactory.Cars.Car_Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Car1
    {
        public Engine engine = new Engine()
        {
            _capacity = "2.5",
            _model = "V8",
        };

        public Consumtion consumtion = new Consumtion()
        {
            maxConsumtion = "20 L",
            average = "10 L",
        };

        public WheelDrive wheelDrive = new WheelDrive()
        {
            wheelDrive = "Front/Back Wheel Drive",
        };
    }
}
