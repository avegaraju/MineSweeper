using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWMineSweeper.Board;
using TWMineSweeper.Exceptions;

namespace TWMineSweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter mine field layout : xxm,xmx,xxx");
            string layout = Console.ReadLine();
            
            Game game = new Game(layout);
            Grid grid =  game.BuildBoard();

            Console.WriteLine("Here is your Mine field.");
            
            game.DisplayGrid(grid);

            while (true)
            {
                try
                {
                    if (game.AreAllMinesSweeped(grid))
                    {
                        Console.WriteLine("Wow you cleared the mine field ! Game Over.");
                        break;
                    }
                    Console.WriteLine("Enter Option: o(0,0)");
                    string option = Console.ReadLine();
                    Grid optionGrid = game.ExecuteOption(option);
                    game.DisplayGrid(optionGrid);
                }
                catch (SteppedOnMineException sEx)
                {
                    Console.WriteLine(sEx.Message);
                    break;
                }
            }

            Console.ReadLine();
        }

      
    }
}
