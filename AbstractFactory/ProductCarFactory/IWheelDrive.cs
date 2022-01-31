using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface IWheelDrive
    {
        public void selectedTypeWheelDrive();
        public string getWheelDriveType();
    }
}
