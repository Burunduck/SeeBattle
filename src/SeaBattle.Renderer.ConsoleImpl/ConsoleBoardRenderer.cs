using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaBattle.Eng.Common.Dto;
using SeaBattle.Renderer.Common;

namespace SeaBattle.Renderer.ConsoleImpl
{
    public class ConsoleBoardRenderer : IBoardRenderer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="board">Игровая доска</param>
        public void Render(GameBoard board)
        {
            int[,] pole = new int[board.SeaHeight, board.SeaWidth];

            foreach (KeyValuePair<Players, List<Ship>> Player in board.Ships)
            {
                if (Player.Key == Players.PlayerA)
                { //Как понять какому игроку устонавливать? 
                    foreach (Ship ship in Player.Value)
                    {
                        if (ship.Orientation == Orientation.Horiz)
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {

                                pole[ship.PosX-1, ship.PosY + i-1] = 1;

                            }

                            foreach (int paluba in ship.Hits)
                            {
                                pole[ship.PosX-1, ship.PosY + paluba-1] = -1;
                            }


                        }
                        else
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {
                                pole[ship.PosX + i-1, ship.PosY-1] = 1;
                            }

                            foreach (int paluba in ship.Hits)
                            {
                                pole[ship.PosX + paluba-1, ship.PosY-1] = -1;
                            }
                        }

                    }
                }
            }

            for (int i = 0; i < board.SeaHeight; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < board.SeaWidth; j++)
                {
                    Console.Write(pole[i, j]+" ");
                }
            }

        }
        var a = new GameBoardFlatWrapper();
                a.[1,2];


        /// <summary>
        /// 
        /// </summary>
        /// <param name="board">Игровая доска</param>
        public void Render(GameBoardFlatWrapper board)
        {
            throw new NotImplementedException();
        }
    }
}
        

    

