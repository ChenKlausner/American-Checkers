using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckersGame;

namespace CheckersGameUI
{
    public class GameManagement
    {
        private const int k_NameLength = 20;
        private readonly FormGameSettings r_FormGameSettings = new FormGameSettings();
        private readonly FormCheckersGame r_FormCheckersGame = new FormCheckersGame();
        private readonly Game r_CheckersGame = new Game();
        private bool m_IsFormSettingsGameClosedByDone = false;

        public GameManagement()
        {
            r_CheckersGame.BoardWasUpdated += new GameBoardUpdatedEventHandler(BoardWasUpdated_EventHandler);
            r_CheckersGame.GameOver += new EventHandler(GameOver_EventHandler);
            r_CheckersGame.InvalidMove += new InvalidMoveEventHandler(InvalidMove_EventHandler);
            r_CheckersGame.PlayerSwitchWasOccured += new EventHandler(PlayerSwitchWasOccured_EventHandler);
            r_FormCheckersGame.MoveOccurred += new MoveOccurredEventHandler(MoveOccurred_EventHandler);
            r_FormGameSettings.FormClosed += new FormClosedEventHandler(FormGameSettingClosed_EventHandler);
            r_FormGameSettings.ClosedByDone += new EventHandler(ClosedByDone_EventHandler);
            r_FormGameSettings.ShowDialog();
        }

        public void RunGame()
        {
            if(m_IsFormSettingsGameClosedByDone == true)
            {
                r_FormCheckersGame.ShowDialog();
            }
        }

        private void startAnotherRound()
        {
            r_CheckersGame.NewGameRoundInitialize();
            r_CheckersGame.IsGameOver = false;
            r_FormCheckersGame.ResetCellButtonsBoard(r_CheckersGame.GameBoard.SizeOfBoard);
            r_FormCheckersGame.UpdateLabelsNameAndScore(r_CheckersGame.CurrentPlayer.PlayerName, r_CheckersGame.CurrentPlayer.Score, r_CheckersGame.Opponent.PlayerName,
                r_CheckersGame.Opponent.Score);
        }

        public void BoardWasUpdated_EventHandler(object sender, GameBoardUpdatedEventArgs e)
        {
            r_FormCheckersGame.UpdateCellBouttonBoard(e);
        }

        public void GameOver_EventHandler(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(getEndGameMessageDetails(), "Checkers Game", MessageBoxButtons.YesNo);

            switch (dialogResult)
            {
                case DialogResult.Yes:
                    startAnotherRound();
                    break;
                case DialogResult.No:
                    r_FormCheckersGame.Close();
                    break;
            }
        }

        public void InvalidMove_EventHandler(object sender, MessageEventArgs e)
        {
            r_FormCheckersGame.ShowMessage(e.MessageToUser);
        }

        public void PlayerSwitchWasOccured_EventHandler(object sender, EventArgs e)
        {
            r_FormCheckersGame.MarkCurrentPlayerLabelName();
        }

        public void MoveOccurred_EventHandler(object sender, MoveOccurredEventArgs e)
        {
            Move newMove = new Move(e.Source, e.Destination);
            r_CheckersGame.MakeCurrentPlayerMove(newMove);
        }

        public void FormGameSettingClosed_EventHandler(object sender, FormClosedEventArgs e)
        {
            ePlayerType playerTwoType = r_FormGameSettings.IsPlayAginstRealPlayer ? ePlayerType.RealPlayer : ePlayerType.Computer;
            r_CheckersGame.InitializeGame(r_FormGameSettings.BoardSize, r_FormGameSettings.PlayerOneName, r_FormGameSettings.PlayerTwoName, playerTwoType);
            r_CheckersGame.BuildPlayerMovesLists();
            r_FormCheckersGame.InitUICheckersGameForm(r_FormGameSettings.BoardSize, r_FormGameSettings.PlayerOneName, r_FormGameSettings.PlayerTwoName);
        }

        public void ClosedByDone_EventHandler(object sender, EventArgs e)
        {
            m_IsFormSettingsGameClosedByDone = true;
        }

        public static bool IsValidGameSettings(string i_PlayerOneName, string i_PlayerTwoName, bool i_IsPlayAginstRealPlayer)
        {
            bool validInput = false;

            if (i_PlayerOneName.Length <= k_NameLength && !i_PlayerOneName.Contains(" ") && i_PlayerOneName.Length > 0)
            {
                if ((!i_IsPlayAginstRealPlayer) || (i_PlayerTwoName.Length <= k_NameLength && !i_PlayerTwoName.Contains(" ") && i_PlayerTwoName.Length > 0))
                {
                    validInput = true;
                }
            }

            return validInput;
        }

        private string getEndGameMessageDetails()
        {
            StringBuilder msg = new StringBuilder();
            if (r_CheckersGame.CheckGameStatus() == eGameStatus.Win || r_CheckersGame.IsGameOver == true)
            {
                msg.Append(string.Format("The winner is {0} !", r_CheckersGame.Opponent.PlayerName));
            }

            if (r_CheckersGame.CheckGameStatus() == eGameStatus.Tie)
            {
                msg.Append(string.Format("It's a Tie! "));
            }

            msg.Append(Environment.NewLine + "Another Round?");

            return msg.ToString();
        }
    }
}
