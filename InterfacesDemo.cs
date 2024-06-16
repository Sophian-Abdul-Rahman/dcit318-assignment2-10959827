/* 
Name: Sophian Abdul Rahman
StudentID: 10959827 
Course: DCIT318
 */
using System;

namespace InterfacesDemo
{
    interface IMovable
    {
        void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Interfaces:");
            car.Move(); // Output: Car is moving
            bicycle.Move(); // Output: Bicycle is moving
        }
    }
}
