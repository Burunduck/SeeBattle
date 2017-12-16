using SeaBattle.Eng.Common;
using SeaBattle.Eng.Common.Dto;
using SeaBattle.Eng.Impl;
using SeaBattle.Renderer.Common;
using SeaBattle.Renderer.ConsoleImpl;

namespace SeaBattle
{
	public static class ConsoleGame
	{
		private static ISeaBattleGame _seaBattleGame;
		private static IBoardRenderer _boardRenderer;

		public static void Start()
		{
			//сборка всех компонентов
			_seaBattleGame = new SeaBattleGame();
			_boardRenderer = new ConsoleBoardRenderer();
			//запускаем игровой цикл
			GameLoop();
		}

		static void GameLoop()
		{
			var initInfo = new InitInfo();
			//todo вводим все инит параметры

			//инитим игру
			_seaBattleGame.ResetAndInit(initInfo);

			while (
				_seaBattleGame.GetCurrentState() == GameStates.TurnPlayerA
				||
				_seaBattleGame.GetCurrentState() == GameStates.TurnPlayerB)
			{
				//todo отрисовываем
				var gameBoard = _seaBattleGame.GetBoard();
				
				var gameBoardFlat = new GameBoardFlatWrapper();
				
				_boardRenderer.Render(gameBoardFlat);

				//делаем ход
				var pos = new GamePosition();
				//todo отображаем подсказку - получаем параметры

				var turnResult = _seaBattleGame.Turn(pos);

				//todo отображаем результат хода
			}

			//todo отобразить победителя
		}
	}
}