using System;
using SeaBattle.Eng.Common;
using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Renderer.ConsoleImpl
{
	public class GameBoardFlat : IGameBoardFlat
	{
		public GameBoard OriginalBoard { get; }
		public Players Player { get; }
		public GameBoardFlatCellKind this[int x, int y] => _flatBoard[x, y];

		private readonly GameBoardFlatCellKind[,] _flatBoard;

		public GameBoardFlat(GameBoard board, Players player)
		{
			OriginalBoard = board;
			Player = player;
			
			_flatBoard = new GameBoardFlatCellKind[board.SeaHeight, board.SeaWidth];
			
			foreach (var ship in board.Ships[player])
			{
				switch (ship.Orientation)
				{
					case Orientation.Horiz:
						for (var i = 0; i < ship.Len; i++)
						{
							_flatBoard[ship.PosX - 1, ship.PosY + i - 1] = GameBoardFlatCellKind.Ship;
						}

						foreach (var paluba in ship.Hits)
						{
							_flatBoard[ship.PosX - 1, ship.PosY + paluba - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					case Orientation.Vert:
						for (int i = 0; i < ship.Len; i++)
						{
							_flatBoard[ship.PosX + i - 1, ship.PosY - 1] = GameBoardFlatCellKind.Ship;
						}

						foreach (int paluba in ship.Hits)
						{
							_flatBoard[ship.PosX + paluba - 1, ship.PosY - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}


	}
}