using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public class Board
    {
        private readonly Cell[,] r_GameBoard;
        private int m_SizeOfBoard;

        public Board(int i_SizeOfBoard)
        {
            m_SizeOfBoard = i_SizeOfBoard;
            r_GameBoard = new Cell[i_SizeOfBoard, i_SizeOfBoard];
        }

        public void InitializeGameBoard()
        {
            int oPlayerEndOfLoop = (m_SizeOfBoard / 2) - 1;
            int xPlayerStartOfLoop = (m_SizeOfBoard / 2) + 1;
            
            for (int i = 0; i < m_SizeOfBoard; i++)
            {
                for (int j = 0; j < m_SizeOfBoard; j++)
                {
                    r_GameBoard[i, j] = new Cell();
                    if (((i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0)) && i < oPlayerEndOfLoop)
                    {
                        r_GameBoard[i, j].Sign = eCharactersOnBoard.SoliderO;
                    }
                    else if (((i % 2 != 0 && j % 2 == 0) || (i % 2 == 0 && j % 2 != 0)) && i >= xPlayerStartOfLoop)
                    {
                        r_GameBoard[i, j].Sign = eCharactersOnBoard.SoliderX;
                    }

                    r_GameBoard[i, j].Position = new Point(i, j);
                }
            }
        }

        public Cell[,] GameBoard
        {
            get
            {
                return r_GameBoard;
            }
        }

        public int SizeOfBoard
        {
            get
            {
                return m_SizeOfBoard;
            }

            set
            {
                m_SizeOfBoard = value;
            }
        }
    }
}
