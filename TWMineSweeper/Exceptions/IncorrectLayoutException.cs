using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Exceptions
{
    /// <summary>
    /// The Exception that is thrown when layout of the board is incorrect.
    /// </summary>
    public class IncorrectLayoutException : ApplicationException
    {
        public IncorrectLayoutException(string message)
            : base(message)
        {
        }
    }
}
