using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    internal class ScoreLabel : Label
    {
        public void player_ScoreChanged(int i_NewScore)
        {
            this.Text = i_NewScore.ToString();
        }
    }
}
