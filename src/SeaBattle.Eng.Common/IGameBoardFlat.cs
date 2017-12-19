using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Eng.Common
{
	public interface IGameBoardFlat
	{
		GameBoard OriginalBoard { get; }

		Players Player { get; }

		GameBoardFlatCellKind GetPlayerCell(int x, int y);
		
		GameBoardFlatCellKind GetOpponentCell(int x, int y);
	}
}