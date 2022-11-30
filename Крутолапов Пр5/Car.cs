using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_5
{
    internal class Car
    {
        public string _brand;
        public int _numberofCylinders;
        public int _power;

        public Car(string brand, int numberofCylinders, int power)
        {
            _brand = brand;
            _numberofCylinders = numberofCylinders;
            _power = power;
        }

        public string Brand
        {
            get { return _brand; }
            set { _brand = value; }
        }

        public int NumberOfCylinders
        {
            get { return _numberofCylinders; }
            set { _numberofCylinders = value; }
        }

        public int Power
        {
            get { return _power; }
            set { _power = value; }
        }

        public void SetParams(string brand)
        {
            Brand = brand;
        }

        public void SetParams(int value, char param)
        {
            if (param == 'n')
            {
                NumberOfCylinders = value;
            }
            else if (param == 'p')
            {
                Power = value;
            }
        }

        public void SetParams(int numberofCylinders, int power, string brand)
        {
            Brand = brand;
            NumberOfCylinders = numberofCylinders;
            Power = power;
        }
    }
}
