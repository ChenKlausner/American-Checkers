using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public delegate void GameBoardUpdatedEventHandler(object sender, GameBoardUpdatedEventArgs e);

    public class GameBoardUpdatedEventArgs : EventArgs
    {
        private Move m_MoveToUpdate;
        private bool m_IsSkipMove;
        private Point m_PositionToErase;
        private int m_GameBoardSize;
        private List<Cell> m_CurrentPlayerPawnsList;
        private List<Cell> m_OpponentPawnsList;
        private eCharactersOnBoard m_PawnCharacterSign;

        public GameBoardUpdatedEventArgs(Move i_MoveToUpdate, bool i_IsSkipMove, Point i_MoveToErase, int i_GameBoardSize, List<Cell> i_CurrentPlayerPawnsList, List<Cell> i_OpponentPawnsList, eCharactersOnBoard i_PawnCharacterSign)
        {
            m_MoveToUpdate = i_MoveToUpdate;
            m_IsSkipMove = i_IsSkipMove;
            m_PositionToErase = i_MoveToErase;
            m_GameBoardSize = i_GameBoardSize;
            m_CurrentPlayerPawnsList = i_CurrentPlayerPawnsList;
            m_OpponentPawnsList = i_OpponentPawnsList;
            m_PawnCharacterSign = i_PawnCharacterSign;
        }

        public Move MoveToUpdate
        {
            get
            {
                return m_MoveToUpdate;
            }
        }

        public bool IsSkipMove
        {
            get
            {
                return m_IsSkipMove;
            }
        }

        public Point PositionToErase
        {
            get
            {
                return m_PositionToErase;
            }
        }

        public int GameBoardSize
        {
            get
            {
                return m_GameBoardSize;
            }
        }

        public List<Cell> CurrentPlayerPawnsList
        {
            get
            {
                return m_CurrentPlayerPawnsList;
            }
        }

        public List<Cell> OpponentPawnsList
        {
            get
            {
                return m_OpponentPawnsList;
            }
        }

        public eCharactersOnBoard PawnCharacterSign
        {
            get
            {
                return m_PawnCharacterSign;
            }
        }
    }
}
