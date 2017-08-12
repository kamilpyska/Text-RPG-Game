using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class SideQuestForm : Form
    {
        int numberOfSideQuest = 0;
        public SideQuestForm()
        {
            InitializeComponent();
        }

        public void updateSideQuestForm(string labelText, string doSideQuestButtonsText, string dontDoSideQuestButtonsText, int whichSideQuest)
        {
            this.sideQuestTextLabel.Text = labelText;
            this.doSideQuestButton.Text = doSideQuestButtonsText;
            this.dontDoSideQuestButton.Text = dontDoSideQuestButtonsText;
            numberOfSideQuest = whichSideQuest;
        }

        private void doSideQuestButton_Click(object sender, EventArgs e)
        {
            GameForm._GameForm.questButton.Enabled = true;
            switch (numberOfSideQuest)
            {
                case 1:
                    GameForm._GameForm.firstSideQuest = true;
                    this.Hide();
                    GameForm._GameForm.changeQuestButtonText("Szukaj bandytów!");
                    GameForm._GameForm.questButtonBlink();
                    break;
                case 2:
                    GameForm._GameForm.secondSideQuest = true;
                    this.Hide();
                    GameForm._GameForm.changeQuestButtonText("Rozejrzyj się.");
                    GameForm._GameForm.questButtonBlink();
                    break;
                case 3:
                    GameForm._GameForm.thirdSideQuest = true;
                    this.Hide();
                    GameForm._GameForm.changeQuestButtonText("Uratuj wilka.");
                    GameForm._GameForm.questButtonBlink();
                    break;
                case 4:
                    GameForm._GameForm.fourthSideQuest = true;
                    this.Hide();
                    GameForm._GameForm.changeQuestButtonText("Walcz!");
                    GameForm._GameForm.questButtonBlink();
                    break;
                case 5:
                    GameForm._GameForm.fifthSideQuest = true;
                    this.Hide();
                    GameForm._GameForm.changeQuestButtonText("Podejdź bliżej.");
                    GameForm._GameForm.questButtonBlink();
                    break;           
            }
        }

        private void dontDoSideQuestButton_Click(object sender, EventArgs e)
        {
            GameForm._GameForm.questButton.Enabled = true;
            this.Hide();
        }
    }
}
