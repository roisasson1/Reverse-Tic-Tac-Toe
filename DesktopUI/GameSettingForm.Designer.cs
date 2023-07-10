
namespace UI
{
    partial class GameSettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playersLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_PlayerTwoCB = new System.Windows.Forms.CheckBox();
            this.m_playerTwoTB = new System.Windows.Forms.TextBox();
            this.m_playerOneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m_numericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.m_numericUpDownCols = new System.Windows.Forms.NumericUpDown();
            this.m_startButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownCols)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.playersLabel.Location = new System.Drawing.Point(13, 9);
            this.playersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(84, 24);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(54, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 2;
            // 
            // m_PlayerTwoCB
            // 
            this.m_PlayerTwoCB.AutoSize = true;
            this.m_PlayerTwoCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_PlayerTwoCB.Location = new System.Drawing.Point(32, 97);
            this.m_PlayerTwoCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_PlayerTwoCB.Name = "m_PlayerTwoCB";
            this.m_PlayerTwoCB.Size = new System.Drawing.Size(95, 22);
            this.m_PlayerTwoCB.TabIndex = 3;
            this.m_PlayerTwoCB.Text = "  Player 2:";
            this.m_PlayerTwoCB.UseVisualStyleBackColor = true;
            this.m_PlayerTwoCB.CheckedChanged += new System.EventHandler(this.m_PlayerTwoCB_CheckedChanged);
            // 
            // m_playerTwoTB
            // 
            this.m_playerTwoTB.Enabled = false;
            this.m_playerTwoTB.Location = new System.Drawing.Point(124, 90);
            this.m_playerTwoTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_playerTwoTB.Name = "m_playerTwoTB";
            this.m_playerTwoTB.Size = new System.Drawing.Size(142, 30);
            this.m_playerTwoTB.TabIndex = 4;
            this.m_playerTwoTB.Text = "[computer]";
            // 
            // m_playerOneTB
            // 
            this.m_playerOneTB.Location = new System.Drawing.Point(124, 46);
            this.m_playerOneTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_playerOneTB.Name = "m_playerOneTB";
            this.m_playerOneTB.Size = new System.Drawing.Size(142, 30);
            this.m_playerOneTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(13, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Board Size:";
            // 
            // m_numericUpDownRows
            // 
            this.m_numericUpDownRows.Location = new System.Drawing.Point(88, 183);
            this.m_numericUpDownRows.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_numericUpDownRows.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_numericUpDownRows.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_numericUpDownRows.Name = "m_numericUpDownRows";
            this.m_numericUpDownRows.Size = new System.Drawing.Size(60, 30);
            this.m_numericUpDownRows.TabIndex = 7;
            this.m_numericUpDownRows.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_numericUpDownRows.ValueChanged += new System.EventHandler(this.m_numericUpDownRows_ValueChanged);
            // 
            // m_numericUpDownCols
            // 
            this.m_numericUpDownCols.Location = new System.Drawing.Point(207, 183);
            this.m_numericUpDownCols.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_numericUpDownCols.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.m_numericUpDownCols.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_numericUpDownCols.Name = "m_numericUpDownCols";
            this.m_numericUpDownCols.Size = new System.Drawing.Size(60, 30);
            this.m_numericUpDownCols.TabIndex = 8;
            this.m_numericUpDownCols.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.m_numericUpDownCols.ValueChanged += new System.EventHandler(this.m_numericUpDownCols_ValueChanged);
            // 
            // m_startButton
            // 
            this.m_startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.m_startButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.m_startButton.Location = new System.Drawing.Point(17, 223);
            this.m_startButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.m_startButton.Name = "m_startButton";
            this.m_startButton.Size = new System.Drawing.Size(250, 40);
            this.m_startButton.TabIndex = 9;
            this.m_startButton.Text = "Start!";
            this.m_startButton.UseVisualStyleBackColor = true;
            this.m_startButton.Click += new System.EventHandler(this.m_startButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(29, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Rows:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(156, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cols:";
            // 
            // GameSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_startButton);
            this.Controls.Add(this.m_numericUpDownCols);
            this.Controls.Add(this.m_numericUpDownRows);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_playerOneTB);
            this.Controls.Add(this.m_playerTwoTB);
            this.Controls.Add(this.m_PlayerTwoCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playersLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Setting";
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_numericUpDownCols)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox m_PlayerTwoCB;
        private System.Windows.Forms.TextBox m_playerTwoTB;
        private System.Windows.Forms.TextBox m_playerOneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown m_numericUpDownRows;
        private System.Windows.Forms.NumericUpDown m_numericUpDownCols;
        private System.Windows.Forms.Button m_startButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}

