using System;
using Task_3;

namespace CIS
{
    class program
    {
        static void Main(string[] args)
        {

            Car car1 = new Car("Fiat","128","1965","Red");
            car1.DisplayInfo();

            Car car2 = new Car("Toyota", "Corolla", "2025");
            car2.DisplayInfo();

            Car car3 = new Car("Mercedes");
            car3.DisplayInfo();

            



        }
    }
}