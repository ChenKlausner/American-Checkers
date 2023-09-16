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
    public partial class FormGameSettings : Form
    {
        public event EventHandler ClosedByDone;

        public FormGameSettings()
        {
            InitializeComponent();
        }

        public int BoardSize
        {
            get
            {
                int boardSize = (int)eBoardSizes.Small;

                if(radioButtonSmall.Checked)
                {
                    boardSize = (int)eBoardSizes.Small;
                }
                else if(radioButtonMedium.Checked)
                {
                    boardSize = (int)eBoardSizes.Medium;
                }
                else
                {
                    boardSize = (int)eBoardSizes.Large;
                }

                return boardSize;
            }
        }

        public string PlayerOneName
        {
            get
            {
                return textBoxPlayerOneName.Text;
            }
        }

        public string PlayerTwoName
        {
            get
            {
                return textBoxPlayerTwoName.Text;
            }
        }

        public bool IsPlayAginstRealPlayer
        {
            get
            {
                return checkBoxPlayerTwo.Checked;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (GameManagement.IsValidGameSettings(this.PlayerOneName, this.PlayerTwoName, this.IsPlayAginstRealPlayer))
            {
                if (!IsPlayAginstRealPlayer)
                {
                    textBoxPlayerTwoName.Text = "Computer";
                }

                OnClosedByDone();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Input! Please enter 20 letters without spaces!");
            }
        }

        private void checkBoxPlayerTwo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPlayerTwoName.Enabled = checkBoxPlayerTwo.Checked;
            textBoxPlayerTwoName.Text = string.Empty;
            if(!checkBoxPlayerTwo.Checked)
            {
                textBoxPlayerTwoName.Text = "[Computer]";
            }
        }

        protected virtual void OnClosedByDone()
        {
            if (ClosedByDone != null)
            {
                ClosedByDone.Invoke(this, new EventArgs());
            }
        }
    }
}
