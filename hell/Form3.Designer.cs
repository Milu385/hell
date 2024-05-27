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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            buttonEquip = new Button();
            buttonDiscard = new Button();
            textBoxReward = new TextBox();
            buttonPlayAgain = new Button();
            SuspendLayout();
            // 
            // buttonEquip
            // 
            buttonEquip.BackgroundImage = (Image)resources.GetObject("buttonEquip.BackgroundImage");
            buttonEquip.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEquip.FlatStyle = FlatStyle.Popup;
            buttonEquip.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEquip.ForeColor = SystemColors.ActiveCaptionText;
            buttonEquip.Location = new Point(16, 286);
            buttonEquip.Margin = new Padding(3, 2, 3, 2);
            buttonEquip.Name = "buttonEquip";
            buttonEquip.Size = new Size(115, 60);
            buttonEquip.TabIndex = 0;
            buttonEquip.Text = "Equip";
            buttonEquip.TextAlign = ContentAlignment.BottomRight;
            buttonEquip.UseVisualStyleBackColor = true;
            buttonEquip.Click += buttonEquip_Click;
            // 
            // buttonDiscard
            // 
            buttonDiscard.BackgroundImage = (Image)resources.GetObject("buttonDiscard.BackgroundImage");
            buttonDiscard.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDiscard.FlatStyle = FlatStyle.Popup;
            buttonDiscard.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonDiscard.Location = new Point(153, 286);
            buttonDiscard.Margin = new Padding(3, 2, 3, 2);
            buttonDiscard.Name = "buttonDiscard";
            buttonDiscard.Size = new Size(115, 60);
            buttonDiscard.TabIndex = 1;
            buttonDiscard.Text = "Discard";
            buttonDiscard.TextAlign = ContentAlignment.BottomRight;
            buttonDiscard.UseVisualStyleBackColor = true;
            buttonDiscard.Click += buttonDiscard_Click;
            // 
            // textBoxReward
            // 
            textBoxReward.Location = new Point(16, 111);
            textBoxReward.Margin = new Padding(3, 2, 3, 2);
            textBoxReward.Multiline = true;
            textBoxReward.Name = "textBoxReward";
            textBoxReward.ReadOnly = true;
            textBoxReward.Size = new Size(252, 97);
            textBoxReward.TabIndex = 2;
            // 
            // buttonPlayAgain
            // 
            buttonPlayAgain.BackgroundImage = (Image)resources.GetObject("buttonPlayAgain.BackgroundImage");
            buttonPlayAgain.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPlayAgain.Enabled = false;
            buttonPlayAgain.FlatStyle = FlatStyle.Popup;
            buttonPlayAgain.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPlayAgain.Location = new Point(547, 286);
            buttonPlayAgain.Margin = new Padding(3, 2, 3, 2);
            buttonPlayAgain.Name = "buttonPlayAgain";
            buttonPlayAgain.Size = new Size(115, 60);
            buttonPlayAgain.TabIndex = 3;
            buttonPlayAgain.Text = "playAgain";
            buttonPlayAgain.TextAlign = ContentAlignment.BottomRight;
            buttonPlayAgain.UseVisualStyleBackColor = true;
            buttonPlayAgain.Click += buttonPlayAgain_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 372);
            Controls.Add(buttonPlayAgain);
            Controls.Add(textBoxReward);
            Controls.Add(buttonDiscard);
            Controls.Add(buttonEquip);
            Margin = new Padding(3, 2, 3, 2);
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