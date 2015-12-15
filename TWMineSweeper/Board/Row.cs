using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMineSweeper.Board
{
    /// <summary>
    /// Represents a Row of Cells in a Mine Sweeper board.
    /// </summary>
    public class Row
    {
        public List<Cell> Cell { get; set; }
        public Row()
        {
            Cell = new List<Cell>();
        }

        public void AddCell(Cell cell)
        {
            Cell.Add(cell);
        }


    }
}
