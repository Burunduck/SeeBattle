using SeaBattle.Eng.Common.Dto;

namespace SeaBattle.Eng.Common
{
    public interface ISeaBattleGame
    {
        void ResetAndInit(InitInfo initInfo);

        GameBoard GetBoard();

        GameStates GetCurrentState();
    }
}