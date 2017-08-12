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
    public partial class ThreeCupsGameForm : Form
    {
        int attempts = 3;
        bool win = false;

        public ThreeCupsGameForm()
        {
            InitializeComponent();
        }

        private int randomWinningCup()
        {
            return GameForm._GameForm.random.Next(1, 4);
        }

        private void gameResult()
        {
            if (win)
            {
                GameForm._GameForm.addLuck(5);
                MessageBox.Show("Gratulacje! Otrzymujesz złotą monetę dającą +5 do szczęścia!");
                this.hideThreeCupsGameFormButton.Visible = true;
                this.firstCupPictureBox.Enabled = false;
                this.secondCupPictureBox.Enabled = false;
                this.thirdCupPictureBox.Enabled = false;
            }
            else
            {
                if (attempts <= 0)
                {
                    MessageBox.Show("Niestety nie udało Ci się wygrać.");
                    this.hideThreeCupsGameFormButton.Text = "Ahh, szkoda.";
                    this.hideThreeCupsGameFormButton.Visible = true;
                    this.firstCupPictureBox.Enabled = false;
                    this.secondCupPictureBox.Enabled = false;
                    this.thirdCupPictureBox.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Pozostało Ci prób: "+ attempts + ".");
                    this.BackgroundImage = Properties.Resources.trzyKubki;
                }
            }
            
        }

        private void firstCupPictureBox_Click(object sender, EventArgs e)
        {
            if (randomWinningCup() == 1)
            {
                win = true;
                this.BackgroundImage = Properties.Resources.pierwszyWygrany;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.pierwszyPrzegrany;
            }
                  
            attempts -= 1;
            gameResult();
        }

        private void secondCupPictureBox_Click(object sender, EventArgs e)
        {
            if (randomWinningCup() == 2)
            {
                win = true;
                this.BackgroundImage = Properties.Resources.drugiWygrany;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.drugiPrzegrany;
            }

            attempts -= 1;
            gameResult();
        }

        private void thirdCupPictureBox_Click(object sender, EventArgs e)
        {
            if (randomWinningCup() == 3)
            {
                win = true;
                this.BackgroundImage = Properties.Resources.trzeciWygrany;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.trzeciPrzegrany;
            }

            attempts -= 1;
            gameResult();
        }

        private void hideThreeCupsGameFormButton_Click(object sender, EventArgs e)
        {
            this.attempts = 3;
            this.win = false;
            GameForm._GameForm.duringTheQuestOrFight = false;
            GameForm._GameForm.questButton.Enabled = true;
            this.firstCupPictureBox.Enabled = true;
            this.secondCupPictureBox.Enabled = true;
            this.thirdCupPictureBox.Enabled = true;
            this.BackgroundImage = Properties.Resources.trzyKubki;
            this.hideThreeCupsGameFormButton.Visible = false;
            this.Hide();
        }
    }
}
