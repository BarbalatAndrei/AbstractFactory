using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.ProductCarFactory
{
    public interface IEngine
    {
        public void selectedTypeEngine();
        public string getTypeEngine();
    }
}
