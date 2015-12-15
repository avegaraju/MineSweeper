using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Exceptions
{
    /// <summary>
    /// The exception that is thrown when user steps on a mine.
    /// </summary>
    public class SteppedOnMineException : ApplicationException
    {
        public SteppedOnMineException(string message)
            : base(message)
        {
        }
    }
}
