namespace Game
{
    partial class MapForm
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
            this.mapPictureBox = new System.Windows.Forms.PictureBox();
            this.hideMapFormButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mapPictureBox
            // 
            this.mapPictureBox.Image = global::Game.Properties.Resources.mapaLvL1;
            this.mapPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mapPictureBox.Name = "mapPictureBox";
            this.mapPictureBox.Size = new System.Drawing.Size(340, 588);
            this.mapPictureBox.TabIndex = 0;
            this.mapPictureBox.TabStop = false;
            // 
            // hideMapFormButton
            // 
            this.hideMapFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideMapFormButton.Location = new System.Drawing.Point(118, 594);
            this.hideMapFormButton.Name = "hideMapFormButton";
            this.hideMapFormButton.Size = new System.Drawing.Size(106, 45);
            this.hideMapFormButton.TabIndex = 1;
            this.hideMapFormButton.Text = "Ok";
            this.hideMapFormButton.UseVisualStyleBackColor = true;
            this.hideMapFormButton.Click += new System.EventHandler(this.hideMapFormButton_Click);
            // 
            // MapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 641);
            this.ControlBox = false;
            this.Controls.Add(this.hideMapFormButton);
            this.Controls.Add(this.mapPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mapa";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.mapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox mapPictureBox;
        private System.Windows.Forms.Button hideMapFormButton;
    }
}