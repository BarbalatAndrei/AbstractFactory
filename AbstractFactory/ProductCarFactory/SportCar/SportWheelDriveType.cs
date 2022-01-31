using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.SportCar
{
    public class SportWheelDriveType : IWheelDrive
    {
        private string wheelDriveType;
        public void selectedTypeWheelDrive()
        {
            wheelDriveType = "Sport";
            Console.WriteLine("Is selected <{0}> Type Wheel Drive", getWheelDriveType());
        }

        public string getWheelDriveType()
        {
            return this.wheelDriveType;
        }
    }
}
