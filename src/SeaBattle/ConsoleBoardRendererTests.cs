using System.Collections.Concurrent;
using System.Collections.Generic;
using SeaBattle.Eng.Common.Dto;
using SeaBattle.Renderer.ConsoleImpl;
using SeaBattle.Eng.Impl;

namespace SeaBattle
{
	public static class ConsoleBoardRendererTests
	{
		public static void Start()
		{
			var renderer = new ConsoleBoardRenderer();

			var gameBoard = new GameBoard();
			gameBoard.SeaHeight = 5;
			gameBoard.SeaWidth = 6;
			gameBoard.ShipCounts = new Dictionary<int, int>
			{
				{2, 1},
			};

			gameBoard.Ships = new Dictionary<Players, List<Ship>>
			{
				{
					Players.PlayerA,
					new List<Ship>
					{
						new Ship
						{
							Hits = new List<int>(),
							Len = 2,
							Orientation = Orientation.Horiz,
							PosX = 2,
							PosY = 3,
						}
					}
				},
				{
					Players.PlayerB,
					new List<Ship>
					{
					}
				},
			};

            var PhysGameBoard = new GameBoardFlat(gameBoard, Players.PlayerA, Players.PlayerB);

			renderer.Render(PhysGameBoard);
		}
	}
}