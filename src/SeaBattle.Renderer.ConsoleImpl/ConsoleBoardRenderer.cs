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
            for (int i = 0; i < board.SeaWidth; i++)
            {
                Console.Write(" "+i);
            }
            for (int i = 0; i < board.SeaHeight; i++)
            {
                Console.WriteLine();
                Console.Write(i+" ");
                for (int j = 0; j <board.SeaWidth ; j++)
                {
                    Console.Write(0+" ");
                }



            }
        }
    }
}
