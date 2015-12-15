using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Board
{
    /// <summary>
    /// Represents a block in a Mine sweeper board.
    /// </summary>
    public class Cell
    {
        public bool IsMine { get; set; }
        public bool IsFlagged { get; set; }
        public bool isOpened { get; set; }
        public Cell(bool isMine)
        {
            this.IsMine= isMine;
            
        }
        public override string ToString()
        {
            string returnValue = string.Empty; ;

            if (IsMine)
                returnValue += " x ";
            else if (isOpened)
                returnValue += " o ";
            else if (IsFlagged)
                returnValue += " f ";
            else
                returnValue += " x ";

            return returnValue;
        }
    }
}
