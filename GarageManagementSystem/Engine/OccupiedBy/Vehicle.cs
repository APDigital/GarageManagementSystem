using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.OccupiedBy
{
    public class Vehicle
    {
        private readonly string NumberPlate;
        public Vehicle(string numberPlate)
        {
            this.NumberPlate = numberPlate;
        }

        public override string ToString()
        {
            return $"{GetType().Name}, NumberPlate: {NumberPlate}";
        }
    }
}
