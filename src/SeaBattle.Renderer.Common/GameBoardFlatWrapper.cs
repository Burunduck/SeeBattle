using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Renderer.Common
{
	public class GameBoardFlatWrapper
	{
		public GameBoard Board { get; set; }
		public Players Player { get; set; }

		public object this[int x, int y]
		{
			get { return null; }
			set
			{
				/* set the specified index to value here */
			}
		}
	}
}