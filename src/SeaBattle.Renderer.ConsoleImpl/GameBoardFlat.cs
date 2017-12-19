using System;
using SeaBattle.Eng.Common;
using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Renderer.ConsoleImpl
{
	public class GameBoardFlat : IGameBoardFlat
	{
		public GameBoard OriginalBoard { get; }
		public Players Player { get; }
		public Players Opponent { get; }

		public GameBoardFlatCellKind GetPlayerCell(int x, int y)
		{
			return _flatBoardForPlayer[x, y];
		}

		public GameBoardFlatCellKind GetOpponentCell(int x, int y)
		{
			return _flatBoardForOpponent[x, y];
		}

		private readonly GameBoardFlatCellKind[,] _flatBoardForPlayer;
		private readonly GameBoardFlatCellKind[,] _flatBoardForOpponent;

		public GameBoardFlat(GameBoard board, Players player, Players opponent)
		{
			OriginalBoard = board;
			Player = player;
			Opponent = opponent;

			_flatBoardForPlayer = new GameBoardFlatCellKind[board.SeaHeight, board.SeaWidth];
			foreach (var ship in board.Ships[player])
			{
				switch (ship.Orientation)
				{
					case Orientation.Horiz:
						for (var i = 0; i < ship.Len; i++)
						{
							_flatBoardForPlayer[ship.PosX - 1, ship.PosY + i - 1] = GameBoardFlatCellKind.Ship;
						}

						foreach (var paluba in ship.Hits)
						{
							_flatBoardForPlayer[ship.PosX - 1, ship.PosY + paluba - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					case Orientation.Vert:
						for (int i = 0; i < ship.Len; i++)
						{
							_flatBoardForPlayer[ship.PosX + i - 1, ship.PosY - 1] = GameBoardFlatCellKind.Ship;
						}

						foreach (int paluba in ship.Hits)
						{
							_flatBoardForPlayer[ship.PosX + paluba - 1, ship.PosY - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}

			_flatBoardForOpponent = new GameBoardFlatCellKind[board.SeaHeight, board.SeaWidth];
			foreach (var ship in board.Ships[opponent])
			{
				switch (ship.Orientation)
				{
					case Orientation.Horiz:
						foreach (var paluba in ship.Hits)
						{
							_flatBoardForPlayer[ship.PosX - 1, ship.PosY + paluba - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					case Orientation.Vert:
						foreach (int paluba in ship.Hits)
						{
							_flatBoardForPlayer[ship.PosX + paluba - 1, ship.PosY - 1] = GameBoardFlatCellKind.ShipHitted;
						}
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
			}
		}
	}
}