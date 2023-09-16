using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGame
{
    public class Move
    {
        private const int k_SingleMoveDistance = 1;
        private const int k_SkipMoveDistance = 2;
        private Point m_Source;
        private Point m_Destination;

        public Move(Point source, Point destination)
        {
            m_Source = source;
            m_Destination = destination;
        }

        public Point Source
        {
            get
            {
                return m_Source;
            }

            set
            {
                m_Source = value;
            }
        }

        public Point Destination
        {
            get
            {
                return m_Destination;
            }

            set
            {
                m_Destination = value;
            }
        }

        public int SubtractionOfXValues
        {
            get
            {
                 return this.Source.X - this.Destination.X;
            }
        }

        public int SubtractionOfYValues
        {
            get
            {
                return this.Source.Y - this.Destination.Y;
            }
        }

        public bool IsMoveInList(List<Move> i_MovesList)
        {
            bool found = false;

            foreach (Move currentMove in i_MovesList)
            {
                if (this.IsEqualMove(currentMove) == true)
                {
                    found = true;
                }
            }

            return found;
        }

        public bool IsEqualMove(Move i_MoveInList)
        {
            return i_MoveInList.m_Source == this.Source && i_MoveInList.m_Destination == this.Destination;
        }
        
        public bool IsSkipMove()
        {
            return Math.Abs(SubtractionOfXValues) == k_SkipMoveDistance && Math.Abs(SubtractionOfYValues) == k_SkipMoveDistance;
        }

        public bool IsSingleMove()
        {
            return Math.Abs(SubtractionOfXValues) == k_SingleMoveDistance && Math.Abs(SubtractionOfYValues) == k_SingleMoveDistance;
        }
    }
}
