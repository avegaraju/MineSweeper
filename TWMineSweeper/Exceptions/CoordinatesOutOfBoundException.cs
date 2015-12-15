using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Exceptions
{
    /// <summary>
    /// The Exception that is thrown when X and Y cordinates are out of the bound.
    /// </summary>
    public class CoordinatesOutOfBoundException : ApplicationException
    {
        public CoordinatesOutOfBoundException(string message):base(message)
        {

        }
    }
}
