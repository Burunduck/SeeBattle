using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Renderer.Common
{
	public interface IBoardRenderer
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="board">Игровая доска</param>
		void Render(GameBoardFlatWrapper board);
	}
}