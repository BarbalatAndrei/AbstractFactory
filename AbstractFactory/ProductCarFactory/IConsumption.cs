using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface IConsumption
    {
        public void selectedTypeConsumtpion();
        public string getTypeConsumtion();
    }
}
