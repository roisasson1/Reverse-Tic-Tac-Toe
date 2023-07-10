using System;
using System.Windows.Forms;
using Engine;

namespace UI
{
    public partial class GameSettingForm : System.Windows.Forms.Form
    {
        private const string k_computer = "[Computer]";
        private readonly Game r_Game;
        public GameSettingForm(Game i_Game)
        {
            r_Game = i_Game;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void m_PlayerTwoCB_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = m_PlayerTwoCB.Checked;

            if(isChecked)
            {
                m_playerTwoTB.Text = "";
                m_playerTwoTB.Enabled = true;
            }
            else
            {
                m_playerTwoTB.Text = k_computer;
                m_playerTwoTB.Enabled = false;
            }
        }

        private void m_numericUpDownCols_ValueChanged(object sender, EventArgs e)
        {
            m_numericUpDownRows.Value = m_numericUpDownCols.Value;
        }

        private void m_numericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            m_numericUpDownCols.Value = m_numericUpDownRows.Value;
        }

        private void m_startButton_Click(object sender, EventArgs e)
        {
            try
            {
                checkValues();

                r_Game.InitGame((int)m_numericUpDownRows.Value, !m_PlayerTwoCB.Checked, m_playerOneTB.Text, m_playerTwoTB.Text);
                r_Game.ResetGame();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Arguments Error", MessageBoxButtons.OK);
            }

        }

        private void checkValues()
        {
            if (m_playerOneTB.Text == string.Empty)
            {
                throw new ArgumentException("Enter player one name");
            }
            if(m_PlayerTwoCB.Checked && m_playerTwoTB.Text == string.Empty )
            {
                throw new ArgumentException("Enter player two name");
            }
        }
    }
}
