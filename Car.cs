using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practic_Classes
{
    public class Car
    {
        public string _make;
        public string _modle;
        public int _year;
        public string _color;
        public int _mileage;

        public Car(string make, string modle, int year, string color, int mileage)
        {
            _make = make;
            _modle = modle;
            _year = year;
            _color = color;
            _mileage = mileage;
        }

        public string Make { get => _make; set => _make = value; }
        public string Modle { get => _modle; set => _modle = value; }
        public int Year { get => _year; set => _year = value; }
        public string Color { get => _color; set => _color = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }
    }
    
}
