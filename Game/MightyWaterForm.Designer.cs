namespace Game
{
    partial class MightyWaterForm
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
            this.hideMightyWaterFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hideMightyWaterFormButton
            // 
            this.hideMightyWaterFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideMightyWaterFormButton.Location = new System.Drawing.Point(247, 432);
            this.hideMightyWaterFormButton.Name = "hideMightyWaterFormButton";
            this.hideMightyWaterFormButton.Size = new System.Drawing.Size(106, 45);
            this.hideMightyWaterFormButton.TabIndex = 0;
            this.hideMightyWaterFormButton.Text = "Ekstra!";
            this.hideMightyWaterFormButton.UseVisualStyleBackColor = true;
            this.hideMightyWaterFormButton.Click += new System.EventHandler(this.hideMightyWaterFormButton_Click);
            // 
            // MightyWaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.dzbanekZWoda;
            this.ClientSize = new System.Drawing.Size(591, 479);
            this.ControlBox = false;
            this.Controls.Add(this.hideMightyWaterFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MightyWaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Woda Wzmocnienia";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hideMightyWaterFormButton;
    }
}