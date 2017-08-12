namespace Game
{
    partial class SideQuestForm
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
            this.sideQuestTextLabel = new System.Windows.Forms.Label();
            this.doSideQuestButton = new System.Windows.Forms.Button();
            this.dontDoSideQuestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sideQuestTextLabel
            // 
            this.sideQuestTextLabel.AutoSize = true;
            this.sideQuestTextLabel.Location = new System.Drawing.Point(28, 23);
            this.sideQuestTextLabel.Name = "sideQuestTextLabel";
            this.sideQuestTextLabel.Size = new System.Drawing.Size(400, 26);
            this.sideQuestTextLabel.TabIndex = 0;
            this.sideQuestTextLabel.Text = "Na jednym z przydrożnych drzew wisi ostrzeżenie o bandytach grasujących w lesie. " +
    "\r\nChcesz ich poszukać?";
            // 
            // doSideQuestButton
            // 
            this.doSideQuestButton.Location = new System.Drawing.Point(86, 102);
            this.doSideQuestButton.Name = "doSideQuestButton";
            this.doSideQuestButton.Size = new System.Drawing.Size(106, 45);
            this.doSideQuestButton.TabIndex = 1;
            this.doSideQuestButton.Text = "Tak";
            this.doSideQuestButton.UseVisualStyleBackColor = true;
            this.doSideQuestButton.Click += new System.EventHandler(this.doSideQuestButton_Click);
            // 
            // dontDoSideQuestButton
            // 
            this.dontDoSideQuestButton.Location = new System.Drawing.Point(279, 102);
            this.dontDoSideQuestButton.Name = "dontDoSideQuestButton";
            this.dontDoSideQuestButton.Size = new System.Drawing.Size(106, 45);
            this.dontDoSideQuestButton.TabIndex = 2;
            this.dontDoSideQuestButton.Text = "Nie";
            this.dontDoSideQuestButton.UseVisualStyleBackColor = true;
            this.dontDoSideQuestButton.Click += new System.EventHandler(this.dontDoSideQuestButton_Click);
            // 
            // SideQuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 196);
            this.ControlBox = false;
            this.Controls.Add(this.dontDoSideQuestButton);
            this.Controls.Add(this.doSideQuestButton);
            this.Controls.Add(this.sideQuestTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SideQuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zadanie poboczne!";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sideQuestTextLabel;
        private System.Windows.Forms.Button doSideQuestButton;
        private System.Windows.Forms.Button dontDoSideQuestButton;
    }
}