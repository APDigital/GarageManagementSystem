using System.Collections.Generic;
using Engine.OccupiedBy;
namespace Engine
{
    public  class ParkingSpace
    {
        private int Width;
        private int Height;
        private bool Occupied;
        private List<Vehicle> vehicle;

        public ParkingSpace(int widthInMetres, int heightInMetres, bool occupied)
        {
            Width = widthInMetres;
            Height = heightInMetres;
            Occupied = occupied;
        }
        public IEnumerable<Vehicle> IsOccupiedBy()
        {
            if (Occupied == true)
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
