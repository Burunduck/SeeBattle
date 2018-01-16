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
			Console.WriteLine($"Player board [{board.Player}]");
			RenderBoard(
				board.OriginalBoard.SeaWidth,
				board.OriginalBoard.SeaHeight,
				board.GetPlayerCell);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Opponent board [{board.Opponent}]");
			RenderBoard(
				board.OriginalBoard.SeaWidth,
				board.OriginalBoard.SeaHeight,
				board.GetOpponentCell);
		}

		private void RenderBoard(int w, int h, Func<int, int, GameBoardFlatCellKind> getCell)
		{
			for (int i = 0; i < w; i++)
			{
				Console.WriteLine();
				for (int j = 0; j < h; j++)
				{
					var cellInt = (int) getCell(j, i);
					Console.Write($"{cellInt} ");
				}
			}
		}
	}
}