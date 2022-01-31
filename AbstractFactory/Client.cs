using AbstractFactory.Cars;
using AbstractFactory.ProductCarFactory;
using AbstractFactory.SportCar;
using AbstractFactory.StandardCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class Client
    {
        public SportProduct sportCarProduct;
        public StandardProduct standardCarProduct;
        public string clientType;
        public Client(IProductCarFactory factory)
        {

            if (factory.GetType() == typeof(SportCarFactory))
            {
                this.sportCarProduct = new SportProduct();
                this.sportCarProduct.SportCarProductFunction();
                this.clientType = "SortType";
            }
            else if(factory.GetType() == typeof(StandardProduct))
            {
                this.standardCarProduct = new StandardProduct();
                this.standardCarProduct.StandardCarProductFunction();
                this.clientType = "StandardType";
            }
        }

        public SportProduct GetSportClientCar()
        {
            return this.sportCarProduct;
        }

        public StandardProduct GetStandardClientCar()
        {
            return this.standardCarProduct;
        }

    }
}
