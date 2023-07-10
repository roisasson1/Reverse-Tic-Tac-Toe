using System.Windows.Forms;
using Engine;

namespace UI
{
    internal class BoardCellButton : Button
    {
        private readonly int r_Row;
        private readonly int r_Column;
        private const string k_PlayerOneSymbol = "X";
        private const string k_PlayerTwoSymbol = "O";
        private const string k_Empty = "";

        public BoardCellButton(int i_Row, int i_Column)
        {
            r_Row = i_Row;
            r_Column = i_Column;
        }

        public int ButtonRow
        {
            get { return r_Row; }
        }

        public int ButtonCol
        {
            get { return r_Column; }
        }

        public void btn_WasClicked(eCellStatus i_NewText)
        {
            if (i_NewText == eCellStatus.Empty)
            {
                this.Text = k_Empty;
                this.Enabled = true;
                this.UseVisualStyleBackColor = true;
            }
            else
            {
                if (i_NewText == eCellStatus.Player1Symobl)
                {
                    this.Text = k_PlayerOneSymbol;
                    this.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    this.Text = k_PlayerTwoSymbol;
                    this.BackColor = System.Drawing.Color.Green;
                }

                this.Enabled = false;
            }
        }
    }
}