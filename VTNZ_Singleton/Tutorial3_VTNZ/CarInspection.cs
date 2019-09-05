using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial3_VTNZ
{
   

    public class CarInspection
    {
        private string _name;
        private decimal _price;

        public string CarInspectionName
        {
            get => _name;
            set => _name = value;
        }

        public decimal CarInspectionPrice
        {
            get => _price;
            set => _price = value;
        }

        public CarInspection() { }

        public CarInspection(string name, decimal price)
        {
            Console.WriteLine("Triggered");
            VTNZ.getInstance("AA", "AA", "AA");
            _name = name;
            _price = price;
        }
    }
}