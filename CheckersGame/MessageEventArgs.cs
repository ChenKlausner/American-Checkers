using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame
{
    public delegate void InvalidMoveEventHandler(object sender, MessageEventArgs e);

    public class MessageEventArgs : EventArgs
    {
        private string m_MessageToUser;

        public MessageEventArgs(string i_MessageToUser)
        {
            m_MessageToUser = i_MessageToUser;
        }

        public string MessageToUser
        {
            get
            {
                return m_MessageToUser;
            }
        }
    }
}
