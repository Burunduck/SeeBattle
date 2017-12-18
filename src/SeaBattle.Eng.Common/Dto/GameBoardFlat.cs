using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Eng.Common.Dto
{
    

    public class GameBoardFlat {
        /// <summary>
        /// Устанавливаю доску
        /// Заполняю двумерный массив(игровое поле) выбранного игрока(В конструкторе обозначен интом)
        /// Ничего не работает...
        /// Понимаю,что что то не подключил, но не понимаю что
        /// </summary>
        public GameBoard board { get; set; }
        int[,] FlatBoard = new int[board.SeaHeight, board.SeaWidth];

        public GameBoardFlat(GameBoard this board,int WhatPlayer)
        {
            foreach (KeyValuePair<Players, List<Ship>> Player in board.Ships)
            {
                if (Player.Key == WhatPlayer)
                {
                    foreach (Ship ship in Player.Value)
                    {
                        if (ship.Orientation == Orientation.Horiz)
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {

                                FlatBoard[ship.PosX - 1, ship.PosY + i - 1] = 1;

                            }

                            foreach (int paluba in ship.Hits)
                            {
                                FlatBoard[ship.PosX - 1, ship.PosY + paluba - 1] = -1;
                            }


                        }
                        else
                        {
                            for (int i = 0; i < ship.Len; i++)
                            {
                                FlatBoard[ship.PosX + i - 1, ship.PosY - 1] = 1;
                            }

                            foreach (int paluba in ship.Hits)
                            {
                                FlatBoard[ship.PosX + paluba - 1, ship.PosY - 1] = -1;
                            }
                        }

                    }
                }
            }
        }

        
    }
}