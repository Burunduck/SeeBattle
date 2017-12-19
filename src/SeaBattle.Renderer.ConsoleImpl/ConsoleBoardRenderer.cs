using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeaBattle.Eng.Common;
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
		public void Render(IGameBoardFlat board)
		{
			for (int i = 0; i < board.OriginalBoard.SeaHeight; i++)
			{
				Console.WriteLine();
				for (int j = 0; j < board.OriginalBoard.SeaWidth; j++)
				{
					Console.Write($"{board[i, j]} ");
				}
			}
		}
	}
}