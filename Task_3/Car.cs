using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Car
    {
        public string brand;
        public string model;
        public string year;
        public string color;

        public Car(string Brand, string Model, string Year,string Color)
        {
            this.brand = Brand;
            this.model = Model;
            this.year = Year;
            this.color = Color;
        }
        public Car(string Brand, string Model, string Year) 
        {
            this.brand = Brand;
            this.model = Model;
            this.year = Year;
            color = "white ";
        }
        public Car(string Brand)
        {
            this.brand = Brand;
            this.model = "unknown";
            this.year = "unknown";
            color = "black ";
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {brand}, Model: {model}, Year: {year}, Color: {color}");
        }
        
    }
}
