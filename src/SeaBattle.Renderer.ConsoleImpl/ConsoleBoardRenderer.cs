﻿using System;
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


            for (int i = 0; i < board.SeaHeight; i++)
            {

                for (int j = 0; j < board.SeaWidth; j++)
                {
                    //todo чё не доверяешь??? я ж доказывал что нули :))))
                    pole[i, j] = 0;
                }



            }
            foreach (KeyValuePair<Players, List<Ship>> Player in board.Ships)
            {
                if (Player.Key == Players.PlayerA)
                { //Как понять какому игроку устонавливать? 
                    foreach (Ship ship in Player.Value)
                    {
                        if (ship.Orientation == 0)
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {

                                pole[ship.PosX, ship.PosY + i] = 1;

                            }

                            foreach (int paluba in ship.Hits)
                            {
                                pole[ship.PosX, ship.PosY + paluba] = -1;
                            }


                        }
                        else
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {
                                pole[ship.PosX + i, ship.PosY] = 1;
                            }

                            foreach (int paluba in ship.Hits)
                            {
                                pole[ship.PosX + paluba, ship.PosY] = -1;
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


    }
}
        

    

