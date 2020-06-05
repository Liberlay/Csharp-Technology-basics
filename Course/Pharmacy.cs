using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Pharmacy
    {

        string name;
        string manufacturer;
        double price;
        int amount;
        int pharmNumber;
        DateTime dateExpired;
        
        public Pharmacy () { }

        public Pharmacy (string name, string manufacturer, double price, int amount, int pharmNumber, DateTime dateExpired)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.amount = amount;
            this.pharmNumber = pharmNumber;
            this.dateExpired = dateExpired;
        }

        public bool CheckIfExpired()
        {
            if (DateTime.Compare(DateTime.Now, this.dateExpired) > 0 )
            {
                return true;
            } else
            {
                return false;
            }
        }


        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public double Price { get => price; set => price = value >= 0 ? value : 0; }
        public int Amount { get => amount; set => amount = value >= 0 ? value : 0; }
        public int PharmNumber { get => pharmNumber; set => pharmNumber = value >= 0 ? value : 0; }
        public DateTime DateExpired { get => dateExpired; set => dateExpired = value; }
    }
}
