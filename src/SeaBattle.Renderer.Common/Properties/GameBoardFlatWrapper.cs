using SeaBattle.Eng.Common.Dto;//Это же нам даёт доступ ко всем файлам из папки дто?

namespace SeaBattle.Renderer.Common
{
	public class GameBoardFlatWrapper
	{
        // Устанавлвиваем нужный нам флетбоард, и вызываем метод WhatIntheseCoord
        //Опять ничего не работает...
        public GameBoardFlat Board { get; set; }
		public Players Player { get; set; }

		public string WhatIntheseCoord(int x, int y)
		{

            if (Board.FlatBoard[x, y] == 1)
            {
                return "Жив";
            }
            if(Board.FlatBoard[x, y] == -1)
            {
                return "Ранен";
            }
            if (Board.FlatBoard[x, y] == 0)
            {
                return "Убит";
            }
            

            

		}
	}
}