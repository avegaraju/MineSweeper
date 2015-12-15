using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Exceptions
{
    /// <summary>
    /// The exception that is thrown when user enters incorrect option.
    /// </summary>
    public class IncorrectOptionException : ApplicationException
    {
        public IncorrectOptionException(string message)
            : base(message)
        {
        }
    }
}
