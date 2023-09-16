using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CheckersGame;

namespace CheckersGameUI
{
    public partial class FormCheckersGame : Form
    {
        private const int k_YPositionOfNameLabels = 22;
        private const int k_CellButtonSize = 50;
        private CellButton[,] cellButtonsBoard;
        private CellButton SourceButton;
        private bool m_IsDestinationButton = false;

        public event MoveOccurredEventHandler MoveOccurred;

        public FormCheckersGame()
        {
            InitializeComponent();
        }

        private void cellButton_Click(object sender, EventArgs e)
        {
            MoveOccurredEventArgs moveEventArgs = null;
            CellButton senderButton = sender as CellButton;
            if (m_IsDestinationButton && senderButton.BackgroundImage == null)
            {
                moveEventArgs = new MoveOccurredEventArgs(SourceButton.Position, senderButton.Position);
                m_IsDestinationButton = false;
                OnMoveOccurred(moveEventArgs);
            }
            else
            {
                if (senderButton.BackgroundImage != null)
                {
                    SourceButton = senderButton;
                    m_IsDestinationButton = true;
                }
            }
        }

        public void InitUICheckersGameForm(int i_BoardSize, string i_NameOfPlayerOne, string i_NameOfPlayerTwo)
        {
            setFormCheckersGameSize(i_BoardSize);
            createCellButtonBoard(i_BoardSize);
            setPlayersLabelsLocation(i_BoardSize);
            UpdateLabelsNameAndScore(i_NameOfPlayerOne, 0, i_NameOfPlayerTwo, 0);
        }

        private void setFormCheckersGameSize(int i_boardSize)
        {
            this.Height = (i_boardSize * k_CellButtonSize) + 100;
            this.Width = (i_boardSize * k_CellButtonSize) + 110;
        }

        private void setPlayersLabelsLocation(int i_boardSize)
        {
            int xPositionLabelNameOne = (i_boardSize * k_CellButtonSize / 4) + (k_CellButtonSize / 2);
            int xPositionLabelNameTwo = i_boardSize * k_CellButtonSize / 4 * 3;
            this.labelPlayer1.Location = new System.Drawing.Point(xPositionLabelNameOne, k_YPositionOfNameLabels);
            this.labelPlayer2.Location = new System.Drawing.Point(xPositionLabelNameTwo, k_YPositionOfNameLabels);
        }

        public void UpdateLabelsNameAndScore(string i_playerOneName, int i_playerOneScore, string i_playerTwoName, int i_playerTwoScore)
        {
            this.labelPlayer1.Text = string.Format("{0}: {1}", i_playerOneName, i_playerOneScore);
            this.labelPlayer2.Text = string.Format("{0}: {1}", i_playerTwoName, i_playerTwoScore);
            labelPlayer1.BackColor = Color.LightGray;
            labelPlayer2.BackColor = Color.Transparent;
        }

        private void createCellButtonBoard(int i_boardSize)
        {
            cellButtonsBoard = new CellButton[i_boardSize, i_boardSize];
            for (int i = 0; i < i_boardSize; i++)
            {
                for (int j = 0; j < i_boardSize; j++)
                {
                    cellButtonsBoard[i, j] = new CellButton(i, j);
                    this.Controls.Add(cellButtonsBoard[i, j]);
                    cellButtonsBoard[i, j].Location = new Point(k_CellButtonSize + (j * k_CellButtonSize), k_CellButtonSize + (i * k_CellButtonSize));
                    cellButtonsBoard[i, j].Click += cellButton_Click;
                }
            }

            ResetCellButtonsBoard(i_boardSize);
        }

        public void ResetCellButtonsBoard(int i_GameBoardSize)
        {
            int oPlayerEndOfLoop = (i_GameBoardSize / 2) - 1;
            int xPlayerStartOfLoop = (i_GameBoardSize / 2) + 1;

            foreach (CellButton currentCell in cellButtonsBoard)
            {
                int i = currentCell.Position.X;
                int j = currentCell.Position.Y;

                currentCell.BackColor = Color.White;
                if (((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) && i < oPlayerEndOfLoop)
                {
                    currentCell.BackgroundImage = global::CheckersGameUI.Properties.Resources.OPawnSolider;
                    currentCell.BackgroundImageLayout = ImageLayout.Stretch;
                    currentCell.Enabled = true;
                }
                else if (((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0)) && i >= xPlayerStartOfLoop)
                {
                    currentCell.BackgroundImage = global::CheckersGameUI.Properties.Resources.XPawnSolider;
                    currentCell.BackgroundImageLayout = ImageLayout.Stretch;
                    currentCell.Enabled = false;
                }
                else if ((i % 2 == 0 && j % 2 == 0) || (i % 2 != 0 && j % 2 != 0))
                {
                    currentCell.Enabled = false;
                    currentCell.BackColor = Color.DarkGray;
                }
                else
                {
                    currentCell.BackgroundImage = null;
                    currentCell.Enabled = true;
                }
            }
        }

        public void UpdateCellBouttonBoard(GameBoardUpdatedEventArgs e)
        {
            bool Enable = true;

            cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImage = cellButtonsBoard[e.MoveToUpdate.Source.X, e.MoveToUpdate.Source.Y].BackgroundImage;
            cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImageLayout = ImageLayout.Stretch;
            cellButtonsBoard[e.MoveToUpdate.Source.X, e.MoveToUpdate.Source.Y].Enabled = true;
            cellButtonsBoard[e.MoveToUpdate.Source.X, e.MoveToUpdate.Source.Y].BackgroundImage = null;
            if (e.IsSkipMove)
            {
                cellButtonsBoard[e.PositionToErase.X, e.PositionToErase.Y].BackgroundImage = null;
                cellButtonsBoard[e.PositionToErase.X, e.PositionToErase.Y].Enabled = true;
            }

            if (e.MoveToUpdate.Destination.X == 0 && e.PawnCharacterSign == eCharactersOnBoard.SoliderX)
            {
                cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImage = global::CheckersGameUI.Properties.Resources.XPawnKing;
                cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImageLayout = ImageLayout.Stretch;
            }

            if (e.MoveToUpdate.Destination.X == e.GameBoardSize - 1 && e.PawnCharacterSign == eCharactersOnBoard.SoliderO)
            {
                cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImage = global::CheckersGameUI.Properties.Resources.OPawnKing;
                cellButtonsBoard[e.MoveToUpdate.Destination.X, e.MoveToUpdate.Destination.Y].BackgroundImageLayout = ImageLayout.Stretch;
            }

            enalbleOrUnEnableCellsButtons(e.CurrentPlayerPawnsList, Enable);
            enalbleOrUnEnableCellsButtons(e.OpponentPawnsList, !Enable);
        }

        private void enalbleOrUnEnableCellsButtons(List<Cell> i_PawnsList, bool i_EnableButton)
        {
            foreach (Cell currentPawn in i_PawnsList)
            {
                cellButtonsBoard[currentPawn.Position.X, currentPawn.Position.Y].Enabled = i_EnableButton;
                cellButtonsBoard[currentPawn.Position.X, currentPawn.Position.Y].BackColor = Color.White;
            }
        }

        public void ShowMessage(string i_MessageToShow)
        {
            MessageBox.Show(i_MessageToShow);
        }

        public void MarkCurrentPlayerLabelName()
        {
            if(labelPlayer1.BackColor == Color.Transparent)
            {
                labelPlayer1.BackColor = Color.LightGray;
                labelPlayer2.BackColor = Color.Transparent;
            }
            else
            {
                labelPlayer1.BackColor = Color.Transparent;
                labelPlayer2.BackColor = Color.LightGray;
            }
        }

        protected virtual void OnMoveOccurred(MoveOccurredEventArgs e)
        {
            if (MoveOccurred != null)
            {
                MoveOccurred.Invoke(this, e);
            }
        }
    }
}
