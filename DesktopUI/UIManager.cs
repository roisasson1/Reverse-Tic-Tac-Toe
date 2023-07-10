using System;
using System.Collections.Generic;
using System.Linq;
using Engine;
using System.Windows.Forms;

namespace UI
{
    internal class UIManager
    {
        private readonly Game r_Game;
       
        public UIManager()
        {
            r_Game = new Game();
        }

        public void StartGame()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new GameSettingForm(r_Game).ShowDialog() == DialogResult.OK)
            {
                new BoardForm(r_Game).ShowDialog();
            }


        }
    }
}
