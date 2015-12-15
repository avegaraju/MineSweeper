using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMineSweeper.Exceptions;

namespace TWMineSweeper.Board
{
    /// <summary>
    /// An X x X Grid to hold the mine sweeper board.
    /// </summary>
    public class Grid
    {

        #region Properties
        public List<Row> GridObj { get; set; }
        #endregion
        
        public Grid()
        {
            GridObj = new List<Row>();
        }

        #region Helper Methods
        public void AddRow(Row row)
        {
            GridObj.Add(row);
        }

        /// <summary>
        /// Creates a board.
        /// </summary>
        /// <param name="row">Number of Rows.</param>
        /// <param name="columns">Number of Columns</param>
        public List<Row> CreateBoard(int rows, int columns, string[] markers)
        {
            if (rows <= 0 || columns <= 0)
                throw new CoordinatesOutOfBoundException("Cordinates must be greater than zero");

            for (int i = 1; i <= rows; i++)
            {
                Row row = new Row();
                string markerRow = markers[i-1];

                for (int j = 1; j <= columns; j++)
                {

                    Cell cell = new Cell(markerRow[j-1].Equals('m')? true: false);

                    row.AddCell(cell);
                    
                }
                GridObj.Add(row);
            }

            return GridObj;
        }

        /// <summary>
        /// Indexer to get a Cell given an X and Y cordinate
        /// </summary>
        /// <param name="x">X Cordinate</param>
        /// <param name="y">Y Cordinate</param>
        /// <returns></returns>
        public Cell this[int x, int y]
        {
            get
            {
                if (GridObj.Count <= x || GridObj[x].Cell.Count <= y)
                    throw new CoordinatesOutOfBoundException("Coordinates are out of bound");
                return GridObj[x].Cell[y];

            }
            set
            {
                if (GridObj.Count <= x || GridObj[x].Cell.Count <= y)
                    throw new CoordinatesOutOfBoundException("Coordinates are out of bound");
                GridObj[x].Cell[y] = value;

            }
        }

        /// <summary>
        /// Method to Flag a Cell as a possible mine.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void FlagCell(int x, int y)
        {
            this[x, y].IsFlagged = true;
        }

        /// <summary>
        /// Method to open a cell.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void OpenCell(int x, int y)
        {
            if(this[x,y].IsMine)
                throw new SteppedOnMineException("Oops you stepped on a mine! Game Over"); 
            
            this[x,y].isOpened = true ;
        }
        /// <summary>
        /// Method to mark a cell as a Mine
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void MineCell(int x, int y)
        {
            this[x, y].IsMine = true;
        }
        #endregion

    }
}
