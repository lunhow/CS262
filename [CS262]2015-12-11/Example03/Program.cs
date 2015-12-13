using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car[] cars = new Car[]
            {
                new Car(){Name="BMW",   Price=4000000, Year=2015},
                new Car(){Name="TOYOTA", Price=800000, Year=2016},
                new Car(){Name="MECEDEZ", Price=1000000, Year=2010}
            };
            Car.GetSortNumber(cars);
            Array.Sort(cars);
            foreach (Car car in cars)
            {
                Console.WriteLine(car.Name);
            }
        }
    }
}