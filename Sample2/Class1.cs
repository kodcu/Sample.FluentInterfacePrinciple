using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample2
{
    public class Car
    {
        private string Name { get; set; }
        private string Plate { get; set; }
        private string Model { get; set; }
        private int Power { get; set; }

        public Car SetPower(int power)
        {
            this.Power = power;
            return this;
        }

        public Car SetModel(string model)
        {
            this.Model = model;
            return this;
        }

        public Car SetName(string name)
        {
            this.Name = name;
            return this;
        }

        public Car SetPlate(string plate)
        {
            this.Plate = plate;
            return this;
        }

    }
}
