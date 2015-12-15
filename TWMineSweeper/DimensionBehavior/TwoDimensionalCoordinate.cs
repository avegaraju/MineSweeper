using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TWMineSweeper.DimensionBehavior
{
    public class TwoDimensionalCoordinate : IDimension
    {

        public string GetCoordinates(string option)
        {
            
            return option.Substring(2, 3);
        }
    }
}
