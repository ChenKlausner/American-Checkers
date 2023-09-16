using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CheckersGameUI
{
    public class CellButton : Button
    {
        private const int k_CellButtonSize = 50;
        private Point m_Position;

        public CellButton(int i_RowNumber, int i_ColNumber)
        {
            m_Position = new Point(i_RowNumber, i_ColNumber);
            this.Size = new Size(k_CellButtonSize, k_CellButtonSize);
        }

        public Point Position
        {
            get
            {
                return m_Position;
            }

            set
            {
                m_Position = value;
            }
        }
    }
}
