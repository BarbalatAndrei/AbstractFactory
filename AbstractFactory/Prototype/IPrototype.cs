using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Prototype
{
    public interface IPrototype
    {
        public IPrototype GetPrototype();
    }
}
