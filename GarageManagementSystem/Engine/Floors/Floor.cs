using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Floors
{
     public class Floor 
    {
        private List<ParkingSpace> Spaces;
        protected Floor(List<ParkingSpace> spaces)
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
