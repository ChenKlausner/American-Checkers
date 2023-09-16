using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CheckersGameUI
{
    public delegate void MoveOccurredEventHandler(object sender, MoveOccurredEventArgs e);

    public class MoveOccurredEventArgs : EventArgs
    {
        private Point m_Source;
        private Point m_Destination;

        public MoveOccurredEventArgs(Point source, Point destination)
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
    }
}
