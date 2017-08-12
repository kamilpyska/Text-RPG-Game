namespace Game
{
    partial class AmuletForm
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
            this.hideAmuletFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hideAmuletFormButton
            // 
            this.hideAmuletFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hideAmuletFormButton.Location = new System.Drawing.Point(248, 427);
            this.hideAmuletFormButton.Name = "hideAmuletFormButton";
            this.hideAmuletFormButton.Size = new System.Drawing.Size(106, 45);
            this.hideAmuletFormButton.TabIndex = 0;
            this.hideAmuletFormButton.Text = "Świetnie!";
            this.hideAmuletFormButton.UseVisualStyleBackColor = true;
            this.hideAmuletFormButton.Click += new System.EventHandler(this.hideAmuletFormButton_Click);
            // 
            // AmuletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.amulet;
            this.ClientSize = new System.Drawing.Size(591, 479);
            this.ControlBox = false;
            this.Controls.Add(this.hideAmuletFormButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AmuletForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amulet trucizny, chorób i osłabienia";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hideAmuletFormButton;
    }
}