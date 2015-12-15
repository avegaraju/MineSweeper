using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.DimensionBehavior
{
    public interface IDimension
    {
        string GetCoordinates(string option);
    }
}
