namespace Game
{
    partial class PotForm
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
            this.potPictureBox = new System.Windows.Forms.PictureBox();
            this.hidePotFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.potPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // potPictureBox
            // 
            this.potPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.potPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.potPictureBox.Location = new System.Drawing.Point(218, 201);
            this.potPictureBox.Name = "potPictureBox";
            this.potPictureBox.Size = new System.Drawing.Size(206, 179);
            this.potPictureBox.TabIndex = 0;
            this.potPictureBox.TabStop = false;
            this.potPictureBox.Click += new System.EventHandler(this.potPictureBox_Click);
            // 
            // hidePotFormButton
            // 
            this.hidePotFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePotFormButton.Location = new System.Drawing.Point(249, 427);
            this.hidePotFormButton.Name = "hidePotFormButton";
            this.hidePotFormButton.Size = new System.Drawing.Size(106, 45);
            this.hidePotFormButton.TabIndex = 1;
            this.hidePotFormButton.Text = "Odłóż dzbanek";
            this.hidePotFormButton.UseVisualStyleBackColor = true;
            this.hidePotFormButton.Visible = false;
            this.hidePotFormButton.Click += new System.EventHandler(this.hidePotFormButton_Click);
            // 
            // PotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.dzbanek3;
            this.ClientSize = new System.Drawing.Size(591, 479);
            this.ControlBox = false;
            this.Controls.Add(this.hidePotFormButton);
            this.Controls.Add(this.potPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postanowiłeś wytrzeć dzbanek z kurzu";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.potPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox potPictureBox;
        private System.Windows.Forms.Button hidePotFormButton;
    }
}