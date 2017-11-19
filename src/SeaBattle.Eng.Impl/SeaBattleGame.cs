﻿using System.Collections.Generic;
using SeaBattle.Eng.Common;
using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Eng.Impl
{
    public class SeaBattleGame : ISeaBattleGame
    {
        private InitInfo _initInfo;
        private IDictionary<Players, List<Ship>> _ships;
        private GameStates _state;

        public void ResetAndInit(InitInfo initInfo)
        {
            _initInfo = initInfo;
            ///
            _state = GameStates.TurnPlayerA;
        }

        public GameBoard GetBoard()
        {
            return new GameBoard
            {
                SeaHeight = _initInfo.SeaHeight,
                SeaWidth = _initInfo.SeaWidth,
                ShipCounts = _initInfo.ShipCounts,
                Ships = _ships
            };
        }

        public GameStates GetCurrentState()
        {
            return _state;
        }
    }
}