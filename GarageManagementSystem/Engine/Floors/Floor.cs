using System.Collections.Generic;

namespace Engine.Floors
{
    public class Floor 
    {
        private List<ParkingSpace> Spaces;
        public Floor(List<ParkingSpace> spaces)
        {
            Spaces = spaces;
        }
        public int GetNumberOfSpaces()
        {
            int numberOfSpaces = Spaces.Count;
            return numberOfSpaces;
        }

        public override string ToString()
        {
            return $"This floor has {GetNumberOfSpaces()} spaces";
        }
    }
}
