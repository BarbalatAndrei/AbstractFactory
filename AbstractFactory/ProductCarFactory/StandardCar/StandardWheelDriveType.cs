using AbstractFactory.ProductCarFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.StandardCar
{
    public class StandardWheelDriveType : IWheelDrive
    {
        private string wheelDriveType;
        public void selectedTypeWheelDrive()
        {
            wheelDriveType = "Standard";
            Console.WriteLine("Is selected <{0}> Type Wheel Drive", getWheelDriveType());
        }

        public string getWheelDriveType()
        {
            return this.wheelDriveType;
        }
    }
}
