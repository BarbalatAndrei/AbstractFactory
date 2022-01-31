using AbstractFactory.Cars;
using AbstractFactory.ProductCarFactory;
using AbstractFactory.SportCar;
using AbstractFactory.StandardCar;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new SportCarFactory());
            SportProduct sportClientCarProduct = client.GetSportClientCar();
            Console.WriteLine("Check real engine type: {0}",sportClientCarProduct.engine.getTypeEngine());
            FindCar clientCar = new FindCar(client);
            displayConcreteCar(clientCar);

            SportProduct cloneSportProduct = sportClientCarProduct.GetPrototype() as SportProduct;
            displayClonedProduct(cloneSportProduct);

            
        }

        public static void displayClonedProduct(SportProduct clonedProduct)
        {
            Console.WriteLine("\n\nClone product...");
            clonedProduct.engine.selectedTypeEngine();
            clonedProduct.consumption.selectedTypeConsumtpion();
            clonedProduct.wheelDrive.selectedTypeWheelDrive();
        }

        public static void displayConcreteCar(FindCar clientCar)
        {
            Console.WriteLine("\n---Example Car: ---");
            Console.WriteLine("Engine Capacity: {0}", clientCar.getCar().engine._capacity);
            Console.WriteLine("Engine Model: {0}", clientCar.getCar().engine._model);
            Console.WriteLine("Max Consumtion: {0}", clientCar.getCar().consumtion.maxConsumtion);
            Console.WriteLine("Wheel Drive: {0}", clientCar.getCar().wheelDrive.wheelDrive);
        }
    }
}
