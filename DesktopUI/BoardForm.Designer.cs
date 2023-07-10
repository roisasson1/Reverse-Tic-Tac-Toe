
namespace UI
{
    partial class BoardForm
    {
        /// Required designer variable.
        private System.ComponentModel.IContainer components = null;

        /// Clean up any resources being used.
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

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        private void InitializeComponent()
        {
            this.m_LabelPlayerTwo = new System.Windows.Forms.Label();
            this.m_LabelPlayerOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_LabelPlayerTwo
            // 
            this.m_LabelPlayerTwo.AutoSize = true;
            this.m_LabelPlayerTwo.Location = new System.Drawing.Point(395, 51);
            this.m_LabelPlayerTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelPlayerTwo.Name = "m_LabelPlayerTwo";
            this.m_LabelPlayerTwo.Size = new System.Drawing.Size(64, 17);
            this.m_LabelPlayerTwo.TabIndex = 3;
            this.m_LabelPlayerTwo.Text = "Player 2:";
            this.m_LabelPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_LabelPlayerOne
            // 
            this.m_LabelPlayerOne.AutoSize = true;
            this.m_LabelPlayerOne.Location = new System.Drawing.Point(175, 51);
            this.m_LabelPlayerOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LabelPlayerOne.Name = "m_LabelPlayerOne";
            this.m_LabelPlayerOne.Size = new System.Drawing.Size(64, 17);
            this.m_LabelPlayerOne.TabIndex = 2;
            this.m_LabelPlayerOne.Text = "Player 1:";
            this.m_LabelPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_LabelPlayerTwo);
            this.Controls.Add(this.m_LabelPlayerOne);
            this.Name = "BoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TicTacToeMisere";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label m_LabelPlayerTwo;
        private System.Windows.Forms.Label m_LabelPlayerOne;
    }
}