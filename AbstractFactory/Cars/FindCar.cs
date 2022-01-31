using AbstractFactory.ProductCarFactory;
using AbstractFactory.SportCar;
using AbstractFactory.StandardCar;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Cars
{
    public class FindCar
    {
        public string typeCar { get; set; }
        public FindCar(Client client)
        {
            if (client.clientType == "SportType")
            {
                typeCar = "SportCar";
            }
            else if (client.clientType == "StandardType")
            {
                typeCar = "StandardCar";
            }
        }

        public Car1 getCar()
        {
            return new Car1();
        }
    }
}
