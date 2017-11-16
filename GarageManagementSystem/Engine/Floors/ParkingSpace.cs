using System.Collections.Generic;
using Engine.OccupiedBy;
namespace Engine
{
    public  class ParkingSpace
    {
        private int Width;
        private int Height;
        private List<Vehicle> vehicle;

        public ParkingSpace(int widthInMetres, int heightInMetres, IEnumerable<Vehicle> vehicles)
        {
            Width = widthInMetres;
            Height = heightInMetres;
            vehicle = new List<Vehicle>(vehicle);
        }
        public IEnumerable<Vehicle> IsOccupiedBy()
        {
            if (vehicle!=null)
            {
                return vehicle;
            }
            return null;
        }
        public string GetSpaceSize()
        {
            string spaceSize;
            if (Width <= 4 || Height <= 2)
            {
                spaceSize = "Small";
            }
            else
            {
                spaceSize = "Large";
            }
            return spaceSize;
        }

        public override string ToString()
        {
            return $"Space Size : {GetSpaceSize()}, Occupied By : {IsOccupiedBy()}";
        }
    }
}
