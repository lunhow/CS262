using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class Car : IProduct, IComparable<Car>
    {
        public int Price { get; set; }

        public string Id { get; set; }

        public int Year { get; set; }

        public int SortNumber { get; set; }

        public string Name
        {
            get;
            set;
        }

        public string GenerateReport()
        {
            return string.Format("Name:{0} Price:{1}", this.Name, this.Price);
        }

        public static int GetSortNumber(Car[] car)
        {
            Console.WriteLine("Please enter Sort number 1) by Price 2) by Year ");
            int sortNumber = int.Parse(Console.ReadLine());
            for (int index = 0; index < car.Length; index++)
            {
                car[index].SortNumber = sortNumber;
            }
            return sortNumber;
        }

        public int CompareTo(Car other)
        {
            //char a = this.Name[this.Name.Length - 1];
            //Console.WriteLine(this.Name);
            //Console.WriteLine("char a {0}", this.Name[this.Name.Length - 1]);
            //char b = other.Name[other.Name.Length - 1];
            //Console.WriteLine(other.Name);
            //Console.WriteLine("char b {0}", other.Name[other.Name.Length - 1]);
            //Console.WriteLine("a-b {0}", a - b);
            //return a - b;

            //Console.WriteLine("Please enter Sort number 1) by Price 2) by Year ");
            //int sortNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("SortNumber = {0}", SortNumber);
            if (SortNumber == 1)
            {
                return this.Price - other.Price;
            }
            else if (SortNumber == 2)
            {
                return this.Year - other.Year;
            }
            else
            {
                Console.WriteLine("please enter valid nummber(1 or 2)");
                return 0;
            }
        }
    }
}