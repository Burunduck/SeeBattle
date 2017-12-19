using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Eng.Common
{
	public interface IGameBoardFlat
	{
		GameBoard OriginalBoard { get; }

		Players Player { get; }

		GameBoardFlatCellKind this[int x, int y] { get; }
	}
}