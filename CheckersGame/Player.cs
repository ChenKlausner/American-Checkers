using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public class Player
    {
        private string m_PlayerName;
        private int m_Score;
        private ePlayerType m_PlayerType;
        private eCharactersOnBoard m_PawnsSign;
        private string m_LastMove;
        private List<Cell> m_PlayerPawnsList;

        public Player(string playerName, ePlayerType playerType, eCharactersOnBoard pawnSign)
        {
            m_PlayerName = playerName;
            m_Score = 0;
            m_PlayerType = playerType;
            m_PawnsSign = pawnSign;
            m_LastMove = null;
            m_PlayerPawnsList = new List<Cell>();
        }

        public string PlayerName
        {
            get
            {
                return m_PlayerName;
            }

            set
            {
                m_PlayerName = value;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }

            set
            {
                m_Score = value;
            }
        }

        public ePlayerType PlayerType
        {
            get
            {
                return m_PlayerType;
            }

            set
            {
                m_PlayerType = value;
            }
        }

        public eCharactersOnBoard PawnSign
        {
            get
            {
                return m_PawnsSign;
            }
        }

        public List<Cell> PlayerPawnsList
        {
            get
            {
                return m_PlayerPawnsList;
            }
        }

        public string LastMove
        {
            get
            {
                return m_LastMove;
            }

            set
            {
                m_LastMove = value;
            }
        }

        public static void Swap(ref Player io_CurrentPlayer, ref Player io_Opponent)
        {
            Player tempPlayer = io_CurrentPlayer;
            io_CurrentPlayer = io_Opponent;
            io_Opponent = tempPlayer;
        }

        public void CreatePlayerPawnsList(Board i_GameBoard)
        {
            foreach (Cell currentCell in i_GameBoard.GameBoard)
            {
                if (currentCell.Sign == m_PawnsSign)
                {
                    m_PlayerPawnsList.Add(currentCell);
                }
            }
        }

        public int CalculatePlayerScore()
        {
            int playerScore = 0;

            foreach (Cell pawn in m_PlayerPawnsList)
            {
                if (pawn.IsKing())
                {
                    playerScore += (int)ePlayerPawnsValue.King;
                }
                else
                {
                    playerScore += (int)ePlayerPawnsValue.Solider;
                }
            }

            return playerScore;
        }
    }
}
