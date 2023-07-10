using System;
using System.Drawing;
using System.Windows.Forms;
using Engine;

namespace UI
{
    public partial class BoardForm : Form
    {
        private readonly Game r_Game;
        private readonly BoardCellButton[,] r_BoardButtons;
        private readonly int r_ButtonsBoardSize;
        private readonly ScoreLabel r_LabelPlayerOneScore, r_LabelPlayerTwoScore;

        public BoardForm(Game i_Game)
        {
            r_Game = i_Game;
            r_ButtonsBoardSize = r_Game.GetBoardSize();
            r_BoardButtons = new BoardCellButton[r_ButtonsBoardSize, r_ButtonsBoardSize];
            r_LabelPlayerOneScore = new ScoreLabel();
            r_LabelPlayerTwoScore = new ScoreLabel();
            InitializeComponent();
            initializeButtons();
            allignScoreLabels();
            alignClientSize();
            boldCurrentPlayerLabels();
        }

        private void initializeButtons()
        {
            int xPosition = 10, yPosition =  10;
            BoardCellButton currentButton = null;

            for (int i = 0; i < r_ButtonsBoardSize; i++)
            {
                for (int j = 0; j < r_ButtonsBoardSize; j++)
                {
                    currentButton = new BoardCellButton(i, j);
                    currentButton.Size = new System.Drawing.Size(50, 50);
                    currentButton.UseVisualStyleBackColor = true;
                    currentButton.Location = new Point(xPosition, yPosition);
                    xPosition += currentButton.Width;
                    currentButton.Click += button_Click;
                    currentButton.TabStop = false;
                    r_BoardButtons[i, j] = currentButton;
                    this.Controls.Add(currentButton);
                    r_Game.AddHandlerToActionMatrix(i + 1, j + 1, currentButton.btn_WasClicked);
                }

                xPosition = 10;
                yPosition = currentButton.Bottom;
            }
        }

        private void boldCurrentPlayerLabels()
        {
            string currPlayer = r_Game.CurrPlayerName;

            if (m_LabelPlayerOne.Text.Contains(currPlayer))
            {
                m_LabelPlayerOne.Font = new Font(m_LabelPlayerOne.Font, FontStyle.Bold);
                r_LabelPlayerOneScore.Font = new Font(r_LabelPlayerOneScore.Font, FontStyle.Bold);
                m_LabelPlayerTwo.Font = new Font(m_LabelPlayerTwo.Font, FontStyle.Regular);
                r_LabelPlayerTwoScore.Font = new Font(r_LabelPlayerTwoScore.Font, FontStyle.Regular);
            }
            else
            {
                m_LabelPlayerTwo.Font = new Font(m_LabelPlayerTwo.Font, FontStyle.Bold);
                r_LabelPlayerTwoScore.Font = new Font(r_LabelPlayerTwoScore.Font, FontStyle.Bold);
                m_LabelPlayerOne.Font = new Font(m_LabelPlayerOne.Font, FontStyle.Regular);
                r_LabelPlayerOneScore.Font = new Font(r_LabelPlayerOneScore.Font, FontStyle.Regular);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            BoardCellButton btn = sender as BoardCellButton;
            int o_Row, o_Column;
            bool gameOver;

            r_Game.MakeMove(btn.ButtonRow + 1, btn.ButtonCol + 1);
            boldCurrentPlayerLabels();
            gameOver = checkGameOver();
            if (r_Game.isPlayerTwoComputer && !gameOver)
            {
                r_Game.GetComputerMove(out o_Row, out o_Column);
                r_Game.MakeMove(o_Row + 1, o_Column + 1);
                boldCurrentPlayerLabels();
                checkGameOver();
            }
        }

        private bool checkGameOver()
        {
            DialogResult PlayerChoice;
            bool gameOver;

            gameOver = r_Game.IsGameOver;
            if (gameOver)
            {
                if (r_Game.IsDraw)
                {
                    PlayerChoice = MessageBox.Show("Tie!\nWould you like to play another round?", "A Tie!", MessageBoxButtons.YesNo);
                }
                else
                {
                    PlayerChoice = MessageBox.Show("The winner is " + r_Game.CurrPlayerName + "!\nWould you like to play another round?", "A Win!", MessageBoxButtons.YesNo);
                }

                if (PlayerChoice == DialogResult.Yes)
                {
                    r_Game.ResetGame();
                    boldCurrentPlayerLabels();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

            return gameOver;
        }

        private void alignClientSize()
        {
            Button lastButton = r_BoardButtons[r_ButtonsBoardSize - 1, r_ButtonsBoardSize - 1];
            int clientSizeWidth = (lastButton.Right + 10);
            int clientSizeHeight = (lastButton.Bottom + 10) + m_LabelPlayerOne.Height * 2;
            this.ClientSize = new Size(clientSizeWidth, clientSizeHeight);
        }

        private void allignScoreLabels()
        {
            string playerOneName, PlayerTwoName;
            Button lastButton = r_BoardButtons[r_ButtonsBoardSize - 1, r_ButtonsBoardSize - 1];
            Button firstButton = r_BoardButtons[0, 0];

            playerOneName = r_Game.GetFirstPlayerName() + ":";
            PlayerTwoName = r_Game.GetSecondPlayerName() + ":";

            //first player name label
            m_LabelPlayerOne.Text = playerOneName;
            m_LabelPlayerOne.Top = lastButton.Bottom + 10;
            m_LabelPlayerOne.Left = (lastButton.Right + firstButton.Left) / 2  - 2 * (lastButton.Width / 2);
            m_LabelPlayerOne.AutoSize = true;

            //first player score label
            initializeScoreLabelForPlayerOne();

            //second player name label
            m_LabelPlayerTwo.Text = PlayerTwoName;
            m_LabelPlayerTwo.Top = m_LabelPlayerOne.Top;
            m_LabelPlayerTwo.Left = r_LabelPlayerOneScore.Right + lastButton.Width/2;
            m_LabelPlayerTwo.AutoSize = true;

            //second player score label
            initializeScoreLabelForPlayerTwo();
        }

        private void initializeScoreLabelForPlayerOne()
        {
            r_LabelPlayerOneScore.AutoSize = true;
            r_LabelPlayerOneScore.Top = m_LabelPlayerOne.Top;
            r_LabelPlayerOneScore.Left = m_LabelPlayerOne.Right + 2;
            r_LabelPlayerOneScore.Name = "m_LabelPlayerOneScore";
            r_LabelPlayerOneScore.Size = new System.Drawing.Size(13, 13);
            r_LabelPlayerOneScore.TabIndex = 2;
            r_LabelPlayerOneScore.Text = "0";
            r_Game.AddPlayerScoreListener(1, r_LabelPlayerOneScore.player_ScoreChanged);
            this.Controls.Add(r_LabelPlayerOneScore);
        }

        private void initializeScoreLabelForPlayerTwo()
        {
            r_LabelPlayerTwoScore.AutoSize = true;
            r_LabelPlayerTwoScore.Top = m_LabelPlayerTwo.Top;
            r_LabelPlayerTwoScore.Left = m_LabelPlayerTwo.Right + 2;
            r_LabelPlayerTwoScore.Name = "m_LabelPlayerTwoScore";
            r_LabelPlayerTwoScore.Size = new System.Drawing.Size(13, 13);
            r_LabelPlayerTwoScore.TabIndex = 3;
            r_LabelPlayerTwoScore.Text = "0";
            r_Game.AddPlayerScoreListener(2, r_LabelPlayerTwoScore.player_ScoreChanged);
            this.Controls.Add(r_LabelPlayerTwoScore);
        }
    }
}