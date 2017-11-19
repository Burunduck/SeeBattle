using SeaBattle.EApp.Common.Dto;

namespace SeaBattle.EApp.Common
{
    public interface ISeaBattleGame
    {
        void ResetAndInit(InitInfo initInfo);

        GameBoard GetBoard();

        GameStates GetCurrentState();
    }
}