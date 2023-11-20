using System;

namespace OOP
{
    // A class is a blueprint of an Object
    internal class Car
    {
        private string _make;
        private string _model;
        private string _color;
        private int _yearBuilt;
        private string _name;

        // Properties
        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }

        public string Model
        {
            get
            {
                return _model;

            }
            set
            {
                _model = value;
            }
        }

        public string Color
        {
            get
            {
                return _color;

            }
            set
            {
                _color = value;
            }
        }

        public int YearBuilt
        {
            get
            {
                return _yearBuilt;

            }
            set
            {
                _yearBuilt = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;

            }
            set
            {
                _name = value;
            }
        }

        // Constructor
        public Car(string make, string model, string color, int year)
        {
            _make = make;
            _model = model;
            _color = color;
            _yearBuilt = year;
            _name = $"{_yearBuilt} {_make} {_model} ";
        }

        // Methods
        public void Accelerate()
        {
            Console.WriteLine($"{_name} is accelerating");
        }
    }
}