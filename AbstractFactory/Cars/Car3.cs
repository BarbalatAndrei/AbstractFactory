using AbstractFactory.Cars.Car_Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Cars
{
    public class Car3
    {
        public Engine engine = new Engine()
        {
            _capacity = "3",
            _model = "V8",
        };

        public Consumtion consumtion = new Consumtion()
        {
            maxConsumtion = "25 L",
            average = "13 L",
        };

        public WheelDrive wheelDrive = new WheelDrive()
        {
            wheelDrive = "Front/Back Wheel Drive",
        };
    }
}
