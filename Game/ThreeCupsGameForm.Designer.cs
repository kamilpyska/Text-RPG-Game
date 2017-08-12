namespace Game
{
    partial class ThreeCupsGameForm
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
            this.firstCupPictureBox = new System.Windows.Forms.PictureBox();
            this.secondCupPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdCupPictureBox = new System.Windows.Forms.PictureBox();
            this.hideThreeCupsGameFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.firstCupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCupPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // firstCupPictureBox
            // 
            this.firstCupPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.firstCupPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.firstCupPictureBox.Location = new System.Drawing.Point(51, 158);
            this.firstCupPictureBox.Name = "firstCupPictureBox";
            this.firstCupPictureBox.Size = new System.Drawing.Size(145, 230);
            this.firstCupPictureBox.TabIndex = 0;
            this.firstCupPictureBox.TabStop = false;
            this.firstCupPictureBox.Click += new System.EventHandler(this.firstCupPictureBox_Click);
            // 
            // secondCupPictureBox
            // 
            this.secondCupPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.secondCupPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondCupPictureBox.Location = new System.Drawing.Point(241, 158);
            this.secondCupPictureBox.Name = "secondCupPictureBox";
            this.secondCupPictureBox.Size = new System.Drawing.Size(154, 229);
            this.secondCupPictureBox.TabIndex = 1;
            this.secondCupPictureBox.TabStop = false;
            this.secondCupPictureBox.Click += new System.EventHandler(this.secondCupPictureBox_Click);
            // 
            // thirdCupPictureBox
            // 
            this.thirdCupPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.thirdCupPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thirdCupPictureBox.Location = new System.Drawing.Point(444, 158);
            this.thirdCupPictureBox.Name = "thirdCupPictureBox";
            this.thirdCupPictureBox.Size = new System.Drawing.Size(146, 228);
            this.thirdCupPictureBox.TabIndex = 2;
            this.thirdCupPictureBox.TabStop = false;
            this.thirdCupPictureBox.Click += new System.EventHandler(this.thirdCupPictureBox_Click);
            // 
            // hideThreeCupsGameFormButton
            // 
            this.hideThreeCupsGameFormButton.Location = new System.Drawing.Point(251, 422);
            this.hideThreeCupsGameFormButton.Name = "hideThreeCupsGameFormButton";
            this.hideThreeCupsGameFormButton.Size = new System.Drawing.Size(106, 45);
            this.hideThreeCupsGameFormButton.TabIndex = 3;
            this.hideThreeCupsGameFormButton.Text = "Haha wygrałem!";
            this.hideThreeCupsGameFormButton.UseVisualStyleBackColor = true;
            this.hideThreeCupsGameFormButton.Visible = false;
            this.hideThreeCupsGameFormButton.Click += new System.EventHandler(this.hideThreeCupsGameFormButton_Click);
            // 
            // ThreeCupsGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.trzyKubki;
            this.ClientSize = new System.Drawing.Size(604, 479);
            this.ControlBox = false;
            this.Controls.Add(this.hideThreeCupsGameFormButton);
            this.Controls.Add(this.thirdCupPictureBox);
            this.Controls.Add(this.secondCupPictureBox);
            this.Controls.Add(this.firstCupPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThreeCupsGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wybierz kubek z monetą.";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.firstCupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdCupPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox firstCupPictureBox;
        private System.Windows.Forms.PictureBox secondCupPictureBox;
        private System.Windows.Forms.PictureBox thirdCupPictureBox;
        private System.Windows.Forms.Button hideThreeCupsGameFormButton;
    }
}