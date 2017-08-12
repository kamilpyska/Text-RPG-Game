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
    public partial class PotForm : Form
    {
        ToolTip tooltip = new ToolTip();
        int pictureBoxClicks = 0;

        public PotForm()
        {
            InitializeComponent();
        }

        private void hidePotFormButton_Click(object sender, EventArgs e)
        {
            GameForm._GameForm.questButton.Enabled = true;
            GameForm._GameForm.duringTheQuestOrFight = false;
            string characterClass = GameForm._GameForm.checkClass();
            string weapon;
            string firstAbility;

            if (characterClass == "Mag")
            {
                weapon = "Tajemny kij";
                firstAbility = "Pocisk mocy";
                characterClass = "magiem";
            }
            else
            {
                weapon = "Miecz";
                firstAbility = "Zwykły cios";
                characterClass = "wojownikiem";
            }

            GameForm._GameForm.addTextToLogTextBox("(Z dzbanka wydobyły się kłęby niebieskiego dymu, kształtem przypominające postać.)" + Environment.NewLine
                + Environment.NewLine + "- Jestem Dżinem z glinianego dzbanka! W nagrodę za uwolnienie mnie spełnię Twoje dwa życzenia! Czegoż sobie życzysz młodzieńcze?"
                + Environment.NewLine + "- Moje życie jest dość monotonne. Jestem tylko pasterzem i codziennie pasę owce... więc może... CHCĘ PRZEŻYĆ JAKĄŚ NIEBEZPIECZNĄ PRZYGODĘ! Najlepiej, gdyby na końcu była księżniczka do uratowania!"
                + Environment.NewLine + Environment.NewLine + "(Dżin zadumał się lekko.)" + Environment.NewLine
                + Environment.NewLine + "- Hmm... Niebezpieczna przygoda z księżniczką..."
                + Environment.NewLine + "- W skrócie można to tak uj..."
                + Environment.NewLine + "- Nie przerywaj, myślę! Księżniczka... Gdzie znajduje się najbliższa księżniczka? Hmm... w wężowej wieży? Nie, ta została uratowana miesiąc temu. W zamku mrocznego maga? Hmm... coś mi się przypomina, że tę też już ktoś uratował..."
                + Environment.NewLine + "Słuchaj, zamiast księżniczki na końcu będzie skarb? Może być? Co Ty na to?"
                + Environment.NewLine + "- Nie, chcę uratować księżniczkę."
                + Environment.NewLine + "- Bogactwo Cię nie interesuje... to może sława?"
                + Environment.NewLine + "- Nie."
                + Environment.NewLine + "- Księżniczka Izabela..."
                + Environment.NewLine + "- Piękne imię!"
                + Environment.NewLine + "- Mówiłem, nie przerywaj! Księżniczka Izabela straciła cierpliwość i sama się uratowała... WIEM! Jest jeszcze jedna księżniczka do uratowania! Za lasami, za górami, za rzeką i gęstą dżunglą, u szczytu wulkanu w grocie mieszka straszliwy potwór, który porwał księżniczkę. Jestem całkiem pewny, że jej jeszcze nikt nie uratował. Spełniłem Twoje życzenie. Wiesz już gdzie jest księżniczka, ruszaj!"
                + Environment.NewLine + "- Hej, hej...a drugie życzenie?"
                + Environment.NewLine + "- Pierwsze - przygoda, spełnione. Drugie - księżniczka, spełnione."
                + Environment.NewLine + "- To było jedno życzenie - przygoda na której końcu uratuję księżniczkę!"
                + Environment.NewLine + "- Haha niech będzie. Mam dziś dobry humor. Jakie jest Twoje drugie życzenie?"
                + Environment.NewLine + "- Chcę zostać " + characterClass + "."
                + Environment.NewLine + "- W porządku. Trzymaj swoją broń, a także pierwszą umiejętność. Kolejne umiejętności i ekwipunek zdobędziesz walcząc. Na tym polega przygoda." + Environment.NewLine
                + Environment.NewLine + "Otrzymałeś " + weapon + " (5 obrażeń) oraz umiejętność " + firstAbility + "." + Environment.NewLine);
            GameForm._GameForm.earnExp(40);
            this.Hide();
        }

        private void potPictureBox_Click(object sender, EventArgs e)
        {
            if (pictureBoxClicks == 0)
            {
                tooltip.Show("Dzbanek wciąż jest w kurzu!", potPictureBox, 0, -20, 2000);
                pictureBoxClicks += 1;
                this.BackgroundImage = Properties.Resources.dzbanek2;
            }
            else if (pictureBoxClicks == 1)
            {
                tooltip.Show("Dzbanek wciąż jest w kurzu!", potPictureBox, 0, -20, 2000);
                pictureBoxClicks += 1;
                this.BackgroundImage = Properties.Resources.dzbanek1;
            }
            else
            {
                tooltip.Show("Dzbanek jest już czysty, ale coś się z nim dzieje!", potPictureBox, 0, -20, 4000);
                this.BackgroundImage = Properties.Resources.dzbanekCzysty;
                hidePotFormButton.Visible = true;
                potPictureBox.Enabled = false;
            }
        }
    }
}
