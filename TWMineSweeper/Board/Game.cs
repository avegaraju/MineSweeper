using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMineSweeper.DimensionBehavior;
using TWMineSweeper.Exceptions;

namespace TWMineSweeper.Board
{
    /// <summary>
    /// Game class which works as an interface.
    /// </summary>
    public class Game
    {
        Grid gridObject;
        IDimension dimension;

        string Layout {get;set;}

        public Game(string layout)
        {
            Layout = layout;
            gridObject = new Grid();
            dimension = new TwoDimensionalCoordinate();
        }

        /// <summary>
        /// Helper method to build the board.
        /// </summary>
        /// <returns></returns>
        public Grid BuildBoard()
        {
            string[] rows ;
            int columnsCount=0;
            int rowsCount=0;
            try
            {
                rows = Layout.Split(',');
                columnsCount = rows[0].Length;
                rowsCount = rows.Length;

            }
            catch (Exception ex)
            {
                throw new IncorrectLayoutException("Please check the layout input. Layout should be: xxm,xmx,xxx");
            }

            gridObject.GridObj = gridObject.CreateBoard(rowsCount, columnsCount,rows);
            return gridObject;

            
        }
        /// <summary>
        /// Method to execute the option entered by user.
        /// </summary>
        /// <param name="option">option with either f to flag and o to open a cell.</param>
        public Grid ExecuteOption(string option)
        {
            char operation;
            int x;
            int y;
            try
            {
                operation = option[0];
                //string coordinates = option.Substring(2, 3);
                string coordinates = this.dimension.GetCoordinates(option);
                string[] cordinateArray = coordinates.Split(',');
                x = int.Parse(cordinateArray[0]);
                y = int.Parse(cordinateArray[1]);

            }
            catch (Exception ex)
            {
                throw new IncorrectOptionException("Please enter the option in correct format. eg o(0,0) or f(1,1)");
            }

            try
            {
                switch (operation)
                {
                    case 'o':
                        gridObject.OpenCell(x, y);
                        break;
                    case 'f':
                        gridObject.FlagCell(x, y);
                        break;
                }
            }
            catch (SteppedOnMineException sEx)
            {
                throw;
            }

            return gridObject;

        }
        /// <summary>
        /// Check of all the mines are sweeped.
        /// </summary>
        /// <returns></returns>
        public bool AreAllMinesSweeped(Grid grid)
        {
            bool isSweeped = true;

            for (int i = 0; i < grid.GridObj.Count; i++)
            {
                for (int j = 0; j < grid.GridObj[i].Cell.Count; j++)
                {
                    if (grid.GridObj[i].Cell[j].ToString().Trim().Equals("x"))
                    {
                        isSweeped = false;
                        return isSweeped;
                    }
                    
                }
            }

            return isSweeped;
        }

        public  void DisplayGrid(Grid grid)
        {
            for (int i = 0; i < grid.GridObj.Count; i++)
            {
                for (int j = 0; j < grid.GridObj[i].Cell.Count; j++)
                {
                    Console.Write(grid.GridObj[i].Cell[j].ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
