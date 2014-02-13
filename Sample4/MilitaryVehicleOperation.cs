using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample4
{
    public class MilitaryVehicleOperation
    {
        private List<Vehicle> _vehicles;
        public MilitaryVehicleOperation()
        {
            this._vehicles = new List<Vehicle>();
        }

        public MilitaryVehicleOperation Add(Vehicle vehicle)
        {
            this._vehicles.Add(vehicle);
            return this;
        }

        public MilitaryVehicleOperation Remove(Vehicle vehicle)
        {
            this._vehicles.Remove(vehicle);
            return this;
        }        

    }

    public class Vehicle
    {
        public int VehicleCode { get; set; }
        public string Plate { get; set; }
        public string AmmoType { get; set; }

        public string Status { get; set; }
        public string SerialNo { get; set; }
    }
}
