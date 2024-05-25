namespace hell
{
    partial class Form3
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
            buttonEquip = new Button();
            buttonDiscard = new Button();
            textBoxReward = new TextBox();
            buttonPlayAgain = new Button();
            SuspendLayout();
            // 
            // buttonEquip
            // 
            buttonEquip.Location = new Point(12, 325);
            buttonEquip.Name = "buttonEquip";
            buttonEquip.Size = new Size(131, 80);
            buttonEquip.TabIndex = 0;
            buttonEquip.Text = "Equip";
            buttonEquip.UseVisualStyleBackColor = true;
            buttonEquip.Click += buttonEquip_Click;
            // 
            // buttonDiscard
            // 
            buttonDiscard.Location = new Point(174, 325);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(131, 80);
            buttonDiscard.TabIndex = 1;
            buttonDiscard.Text = "Discard";
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // textBoxReward
            // 
            textBoxReward.Location = new Point(18, 92);
            textBoxReward.Multiline = true;
            textBoxReward.Name = "textBoxReward";
            textBoxReward.ReadOnly = true;
            textBoxReward.Size = new Size(287, 128);
            textBoxReward.TabIndex = 2;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.Enabled = false;
            buttonPlayAgain.Location = new Point(628, 325);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(131, 80);
            buttonPlayAgain.TabIndex = 3;
            buttonPlayAgain.Text = "playAgain";
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPlayAgain);
            Controls.Add(textBoxReward);
            Controls.Add(buttonDiscard);
            Controls.Add(buttonEquip);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button buttonEquip;
        public Button buttonDiscard;
        public TextBox textBoxReward;
        public Button buttonPlayAgain;
    }
}