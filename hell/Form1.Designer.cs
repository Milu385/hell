namespace hell
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button_play = new Button();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // button_play
            // 
            button_play.BackgroundImageLayout = ImageLayout.Stretch;
            button_play.Location = new Point(562, 286);
            button_play.Name = "button_play";
            button_play.Size = new Size(133, 69);
            button_play.TabIndex = 0;
            button_play.Text = "play";
            button_play.UseVisualStyleBackColor = true;
            button_play.Click += button_play_Click;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.ButtonFace;
            textBoxName.Location = new Point(75, 296);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(197, 23);
            textBoxName.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(763, 416);
            Controls.Add(textBoxName);
            Controls.Add(button_play);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "hell";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_play;
        private TextBox textBoxName;
    }
}
