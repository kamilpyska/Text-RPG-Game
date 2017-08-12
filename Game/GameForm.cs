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
    public partial class GameForm : Form
    {
        MapForm mapForm = new MapForm();
        SideQuestForm sideQuestForm = new SideQuestForm();
        ThreeCupsGameForm threeCupsGameForm = new ThreeCupsGameForm();
        AmuletForm amuletForm = new AmuletForm();
        MightyWaterForm mightyWaterForm = new MightyWaterForm();
        List<Monster> currentlyFigthingMonsters = new List<Monster>();
        public bool duringTheQuestOrFight = false;
        string maxCharacterLife = "maxLife";
        int expForQuestComplete = 0;
        public bool firstSideQuest = false;
        public bool secondSideQuest = false;
        public bool thirdSideQuest = false;
        public bool fourthSideQuest = false;
        public bool fifthSideQuest = false;
        bool afterThirdQuest = false;
        bool afterFourthQuest = false;
        bool afterFifthQuest = false;
        bool afterSixthQuest = false;
        bool afterSeventhQuest = false;
        bool afterEightQuest = false;
        bool afterNinthQuest = false;
        public Random random = new Random(Guid.NewGuid().GetHashCode());
        public static GameForm _GameForm;

        List<string> allMonstersList = new List<string>() {
           "Szkielet",
            "Troll",
            "Nieumarły",
            "Mały demon",
            "Duża żaba",
            "Duch",
            "Zabłąkana dusza",
            "Skrzat",
            "Nocnica",
            "Ork",
            "Gnom",
            "Goblin",
            "Mara",
            "Mały czart",
            "Dzik z Mrocznego Lasu",
            "Niedźwiedź z Mrocznego Lasu",
            "Drzewiec",
            "Duch lasu",
            "Strażnik lasu",
            "Wilkołak z Mrocznego Lasu",
            "Leśny chochlik",
            "Wilk z Mrocznego Lasu",
            "Leśny Wąpierz",
            "Leszy",
            "Żywiołak ziemi",
            "Leśne ogniki",
            "Olbrzymia muchołówka",
            "Żywiołak wody",
            "Topielec",
            "Duża pijawka",
            "Troll rzeczny",
            "Duch rzeki",
            "Niebieska żaba",
            "Wodnik",
            "Rybiczłek",
            "Rzeczny wąż",
            "Krokodyl",
            "Wij",
            "Brzeginka",
            "Bagiennik",
            "Wygłodniały lew",
            "Dzika pantera",
            "Wściekły tygrys",
            "Wredna małpa",
            "Jaszczuroczłek zbieracz",
            "Jaszczuroczłek wojownik",
            "Jaszczuroczłek przywódca",
            "Jaszczurczłek kapłan smoków",
            "Jaszczuroczłek mag",
            "Hiena",
            "Pyton",
            "Hydra",
            "Anakonda",
            "Górski olbrzym",
            "Yeti",
            "Żywiołak lodu",
            "Śnieżny stwór",
            "Górski troll",
            "Górski wilk",
            "Lodowy gigant",
            "Lodowy feniks",
            "Kamienny gargulec",
            "Górski wilk",
            "Kobra",
            "Skorpion",
            "Żmija pustynna",
            "Żywy piasek",
            "Mysz pustynna",
            "Mrówka pustynna",
            "Żywa magma",
            "Wulkaniczny gigant",
            "Żywiołak ognia",
            "Smok",
            "Demon ognia",
            "Wulkaniczna żaba",
            "Ognisty jaszczur",
            "Zjadacz lawy"
        };

        List<string> commonMonstersList = new List<string>() {
             "Szkielet",
             "Troll",
             "Nieumarły",
             "Mały demon",
             "Duża żaba",
             "Duch",
             "Zabłąkana dusza",
             "Skrzat",
             "Nocnica",
             "Ork",
             "Gnom",
             "Goblin",
             "Mara",
             "Mały czart"
        };

        List<string> forestMonstersList = new List<string>() {
            "Dzik z Mrocznego Lasu",
            "Niedźwiedź z Mrocznego Lasu",
            "Drzewiec",
            "Duch lasu",
            "Strażnik lasu",
            "Wilkołak z Mrocznego Lasu",
            "Leśny chochlik",
            "Wilk z Mrocznego Lasu",
            "Leśny Wąpierz",
            "Leszy",
            "Żywiołak ziemi",
            "Leśne ogniki",
            "Olbrzymia muchołówka"
        };

        List<string> waterMonstersList = new List<string>() {
            "Żywiołak wody",
            "Topielec",
            "Duża pijawka",
            "Troll rzeczny",
            "Duch rzeki",
            "Niebieska żaba",
            "Wodnik",
            "Rybiczłek",
            "Rzeczny wąż",
            "Krokodyl",
            "Wij",
            "Brzeginka",
            "Bagiennik"
        };

        List<string> jungleMonstersList = new List<string>() {
            "Wygłodniały lew",
            "Dzika pantera",
            "Wściekły tygrys",
            "Wredna małpa",
            "Jaszczuroczłek zbieracz",
            "Jaszczuroczłek wojownik",
            "Jaszczuroczłek przywódca",
            "Jaszczurczłek kapłan smoków",
            "Jaszczuroczłek mag",
            "Hiena",
            "Pyton",
            "Hydra",
            "Anakonda"
        };

        List<string> mountainMonstersList = new List<string>() {
            "Górski olbrzym",
            "Yeti",
            "Żywiołak lodu",
            "Śnieżny stwór",
            "Górski troll",
            "Górski wilk",
            "Lodowy gigant",
            "Lodowy feniks",
            "Kamienny gargulec",
            "Górski wilk"
        };

        List<string> desertMonstersList = new List<string>() {
            "Kobra",
            "Skorpion",
            "Żmija pustynna",
            "Żywy piasek",
            "Mysz pustynna",
            "Mrówka pustynna"
        };

        List<string> volcanoMonstersList = new List<string>() {
            "Żywa magma",
            "Wulkaniczny gigant",
            "Żywiołak ognia",
            "Smok",
            "Demon ognia",
            "Wulkaniczna żaba",
            "Ognisty jaszczur",
            "Zjadacz lawy"
        };

        public GameForm()
        {
            InitializeComponent();
            _GameForm = this;
        }

        /// <summary>
        /// Ładowanie danych do kontrolek.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameForm_Load(object sender, EventArgs e)
        {
            this.characterTableAdapter.Fill(this.gameDBDataSet.Character);
            
            //Jeżeli zaczynamy od wczytanego zapisu (positionItem jest wtedy większy od 0), to questButton powinien być 
            //dostępny. Jeżeli uruchamiamy grę pierwszy raz (nie mamy żadnych zapisów), to blokuj questButton. 
            if (this.bindingNavigatorPositionItem.Text.Trim() == "0")
            {
                this.questButton.Enabled = false;
            }

            if (this.expValueLabel.Text != "0" || this.expValueLabel.Text != "")
            {
                this.nameTextBox.Enabled = false;
                this.classComboBox.Enabled = false;
            }
        }

        /// <summary>
        /// Metoda odpowiada za przyjmowanie obrażeń przez postać. Obrażenia pochłania najpierw pancerz, 
        /// a nastepnie dopiero postać, o ile wartość obrażeń jest większa od ilości punktów pancerza.
        /// </summary>
        /// <param name="damage"></param>
        private void characterTakeDamage(string enemy, int damage)
        {
            int newLife = 0;
            int characterArmor = Convert.ToInt32(this.helmetValueLabel.Text) +
                Convert.ToInt32(this.breastplateValueLabel.Text) +
                Convert.ToInt32(this.glovesValueLabel.Text) +
                Convert.ToInt32(this.bootsValueLabel.Text);

            if (damage > characterArmor)
            {
                newLife = Convert.ToInt32(this.lifeValueLabel.Text) + characterArmor - damage;
                this.lifeValueLabel.Text = newLife.ToString();
                addTextToLogTextBox(enemy + " zadaje " + (damage - characterArmor) +
                    " obrażeń. Twój pancerz pochłonął " + characterArmor + " obrażeń.");
            }
            else
            {
                addTextToLogTextBox(enemy + " atakuje! Twój pancerz pochłonął całość " + damage + " obrażeń.");
            }
        }

        /// <summary>
        /// Zależnie od przekazanej umiejętności wywołuje odpowiadające im metody.
        /// </summary>
        /// <param name="ability"></param>
        private void characterUseAbility(string ability)
        {
            switch (ability)
            {
                case "Zwykły cios":
                case "Pocisk mocy":
                    addTextToLogTextBox("Używasz " + ability + "!");
                    attack(30, 50);
                    break;
                case "Leczenie":
                    addTextToLogTextBox("Używasz Leczenia!");
                    heal(100);
                    break;
                case "Większe leczenie":
                    addTextToLogTextBox("Używasz Większego leczenia!");
                    heal(200);
                    break;
                case "Tornado ostrzy":
                case "Fala ognia":
                    addTextToLogTextBox("Używasz " + ability + "!");
                    areaOfEffectAttack(30, 50);
                    break;
                case "Cięcie wichru":
                case "Kula ognia":
                    addTextToLogTextBox("Używasz " + ability + "!");
                    attack(50, 100);
                    break;
                case "Okrzyk bojowy":
                case "Klątwa pecha":
                    addTextToLogTextBox("Używasz " + ability + "!");
                    lowerMonsterLuck(0.5);
                    break;
                case "Strzaskanie pancerza":
                case "Klątwa rdzy":
                    addTextToLogTextBox("Używasz " + ability + "!");
                    lowerMonsterArmor(0.5, ability);
                    break;
            }
        }

        /// <summary>
        /// Zadaje obrażenia pierwszemu celowi z listy.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private void attack(int min, int max)
        {
            int targetIndex = this.targetComboBox.SelectedIndex;
            Monster targetMonster = currentlyFigthingMonsters[targetIndex];
            int abilityDamage = random.Next(min, max+1);
            int damage = Convert.ToInt32(this.dmgValueLabel.Text) + Convert.ToInt32(wDmgValueLabel.Text) + abilityDamage;
            if (random.Next(0, 101) <= Convert.ToInt32(this.luckValueLabel.Text))
            {
                damage = Convert.ToInt32(Math.Floor(damage * 1.3));
                addTextToLogTextBox("Krytyczny atak!");
            }
            addTextToLogTextBox("Uderzasz za " + damage + "!" + targetMonster.TakeDamage(damage));
            if (targetMonster.Life <= 0)
            {
                addTextToLogTextBox(Environment.NewLine + "Zabijasz " + targetMonster.Name + "!");
                lookForLoot(targetMonster.Rarity, targetMonster.Lvl);
                //Doświadczenie jest przyznawane do 78 poziomu, ponieważ do osiągnięcia kolejnego poziomu przekroczyłoby granicę wartości typu int.
                if (Convert.ToInt32(this.lvlValueLabel.Text) < 78)
                {
                    earnExp(targetMonster);
                }
                currentlyFigthingMonsters.RemoveAt(targetIndex);
                this.targetComboBox.Items.RemoveAt(targetIndex);
                if (currentlyFigthingMonsters.Any())
                {
                    this.targetComboBox.SelectedIndex = 0;
                }

            }
            if (!currentlyFigthingMonsters.Any())
            {
                afterKillingAllEnemies();
            }
        }

        /// <summary>
        ///Zadaje obrażenia wszystkim celom z listy. 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private void areaOfEffectAttack(int min, int max)
        {
            int abilityDamage = random.Next(min, max+1);
            int damage = Convert.ToInt32(this.dmgValueLabel.Text) + Convert.ToInt32(wDmgValueLabel.Text) + abilityDamage;
            addTextToLogTextBox("Uderzasz za " + damage + "!");

            foreach (var monster in currentlyFigthingMonsters)
            {
                addTextToLogTextBox(monster.TakeDamage(damage));
            }
            for (int i = 0; i < currentlyFigthingMonsters.Count(); i++)
            {
                Monster monster = currentlyFigthingMonsters[i];
                if (monster.Life <= 0)
                {
                    addTextToLogTextBox(Environment.NewLine + "Zabijasz " + monster.Name + "!");
                    lookForLoot(monster.Rarity, monster.Lvl);
                    if (Convert.ToInt32(this.lvlValueLabel.Text) < 78)
                    {
                        earnExp(monster);
                    }
                    currentlyFigthingMonsters.Remove(monster);
                    this.targetComboBox.Items.RemoveAt(i);
                    if (currentlyFigthingMonsters.Any())
                    {
                        this.targetComboBox.SelectedIndex = 0;
                    }
                    i--;
                }
            }
            if (!currentlyFigthingMonsters.Any())
            {
                afterKillingAllEnemies();
            }
        }

        /// <summary>
        ///Leczenie za wartość z parametru. 
        /// </summary>
        /// <param name="healing"></param>
        private void heal(int healing)
        {
            int currentCharacterLife = Convert.ToInt32(this.lifeValueLabel.Text);
            int wounds = Convert.ToInt32(maxCharacterLife) - currentCharacterLife;

            if (wounds >= healing)
            {
                this.lifeValueLabel.Text = Convert.ToString(currentCharacterLife + healing);
                addTextToLogTextBox("Wyleczyłeś " + healing + " obrażeń.");
            }
            else
            {
                this.lifeValueLabel.Text = Convert.ToString(currentCharacterLife + wounds);
                addTextToLogTextBox("Wyleczyłeś " + wounds + " obrażeń.");
            }
        }

        /// <summary>
        /// Sprawdza czy stwór jest odpowiedniego typu i wywoluje u niego metodę odpowiedzialną 
        /// za obniżenie szczęścia.
        /// </summary>
        private void lowerMonsterLuck(double percent)
        {
            int targetIndex = this.targetComboBox.SelectedIndex;
            if (currentlyFigthingMonsters.First() is LuckyMonster)
            {
                LuckyMonster targetLuckyMonster = currentlyFigthingMonsters[targetIndex] as LuckyMonster;
                addTextToLogTextBox(targetLuckyMonster.LowerLuck(percent));
            }
            else
            {
                addTextToLogTextBox("Szczęście tego stwora już wynosi 0.");
            }
        }

        /// <summary>
        /// Sprawdza czy stwór jest odpowiedniego typu i wywoluje u niego metodę odpowiedzialną 
        /// za obniżenie pancerza.
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="ability"></param>
        private void lowerMonsterArmor(double percent, string ability)
        {
            int targetIndex = this.targetComboBox.SelectedIndex;
            if (currentlyFigthingMonsters[targetIndex] is IHasArmor)
            {
                IHasArmor targetArmoredMonster = currentlyFigthingMonsters[targetIndex] as IHasArmor;
                addTextToLogTextBox(targetArmoredMonster.LowerArmor(percent, ability));
            }
            else
            {
                addTextToLogTextBox("Ten stwór nie nosi pancerza!");
            }
        }

        /// <summary>
        /// Metoda przyznaje doświadczenie za główne zadania oraz przygotowuje kontrolki do następnych.
        /// </summary>
        private void afterKillingAllEnemies()
        {
            addTextToLogTextBox(Environment.NewLine + "Pokonałeś wszystkich przeciwników!");
            if (expForQuestComplete != 0)
            {
                earnExp(expForQuestComplete);
                expForQuestComplete = 0;
            }
            if (!(firstSideQuest || secondSideQuest || thirdSideQuest || fourthSideQuest || fifthSideQuest || afterThirdQuest || afterFourthQuest || afterFifthQuest || afterSixthQuest || afterSeventhQuest || afterEightQuest || afterNinthQuest))
            {
                this.bindingNavigatorMoveFirstItem.Enabled = true;
                this.bindingNavigatorMoveNextItem.Enabled = true;
                this.bindingNavigatorMovePreviousItem.Enabled = true;
                this.bindingNavigatorMoveLastItem.Enabled = true;
                this.bindingNavigatorDeleteItem.Enabled = true;
                this.bindingNavigatorAddNewItem.Enabled = true;
            }
            this.questButton.Enabled = true;
            this.useButton.Enabled = false;
            this.lifeValueLabel.Text = maxCharacterLife;
            duringTheQuestOrFight = false;
            this.targetComboBox.Text = "";
            this.targetComboBox.Items.Clear();
            checkForLvlUp();
        }

        /// <summary>
        /// Zapelnia listę currentFightingMonsters przeskalowanymi potworami, uruchamia misje poboczne,
        /// a także dodaje tekst fabuły wyświetlany po zakończeniu danego głównego zadania.
        /// </summary>
        /// <returns></returns>
        private void simpleQuest()
        {
            if (firstSideQuest)
            {
                sideQuest(1);
            }
            else if(secondSideQuest)
            {
                sideQuest(2);
            }
            else if (thirdSideQuest)
            {
                sideQuest(3);
            }
            else if (fourthSideQuest)
            {
                sideQuest(4);
            }
            else if (fifthSideQuest)
            {
                sideQuest(5);
            }
            else if (afterThirdQuest)
            {
                this.questButton.Enabled = false;
                sideQuestForm.updateSideQuestForm("Chciałbyś chwilę się rozejrzeć w tym miejscu?", "Tak", "Nie", 2);
                sideQuestForm.Show();
                afterThirdQuest = false;
            }
            else if (afterFourthQuest)
            {
                addTextToLogTextBox(Environment.NewLine + "- Za tymi górami znajduje się most nad rzeką Dwóch Światów. W górach żyje Pani Zamieci i lepiej żebyśmy jej nie spotkali. Nikt nie przeżył z ludzi, którzy ją widzieli."
                    + Environment.NewLine + "- Jeżeli nikt nie przeżył, to skąd wiadomo, że tam jest? Może to jakiś groźny niedźwiedź lub Yeti?"
                    + Environment.NewLine + "- Wieśniacy złapali kiedyś śnieżnego trolla, który jej służył i to od niego wiemy o  Pani Zamieci."
                    + Environment.NewLine + "- Troll mógł kłamać by ujść z życiem."
                    + Environment.NewLine + "- Mógł, ale mógł też mówić prawdę, zwłaszcza, że wyczuwam silną magię z kierunku gór."
                    + Environment.NewLine + "- Powiedz mi jeszcze skąd wzięła się nazwa rzeki - Dwa Światy?"
                    + Environment.NewLine + "- Z bardzo prozaicznej przyczyny. Po jednej stronie są góry skute lodem i pokryte śniegiem. Po drugiej zielona dżungla. Rzeka jest granicą dla tych dwóch, kontrastujących ze sobą światów. Stąd jej nazwa.");
                afterFourthQuest = false;
                this.questButton.Enabled = false;
                sideQuestForm.updateSideQuestForm("Widzisz, że Olbrzymia muchołówka złapała w swoją paszczę wilka."
                    + Environment.NewLine + "Wilk próbuje się wyrwać, pomagasz mu?", "Co mi szkodzi?", "Zostawmy naturę samą sobie.",3);
                sideQuestForm.Show();
            }
            else if (afterFifthQuest)
            {
                addTextToLogTextBox(Environment.NewLine + "- Nieoczekiwanie, udało Ci się przeżyć... Tą drogą dojdziesz do mostu nad rzeką Dwóch światów, a teraz odejdź nim przygotuję Ci kolejną próbę."
                    + Environment.NewLine + "- Przejdziemy most i co dalej Dżinie?"
                    + Environment.NewLine + "- Do walki z potworem, który porwał księżniczkę będziesz potrzebował dwóch artefaktów. Pierwszy jest ukryty w świątyni Jaszczuroludzi w dżungli."
                    + Environment.NewLine + "- Co to za artefakt?"
                    + Environment.NewLine + "- To tajemny amulet trucizny, chorób i osłabienia. Jaszczuroludzie oddają mu cześć w swojej świątyni dzięki czemu nie chorują."
                    + Environment.NewLine + "- Pewnie nie będą chcieli mi go pożyczyć?"
                    + Environment.NewLine + "- To ich największy skarb, lepiej szykuj się na walkę.");
                afterFifthQuest = false;
            }
            else if (afterSixthQuest)
            {
                addTextToLogTextBox(Environment.NewLine + "(Goryl rozpadł się zostawiając sporą stertę gruzu.)"
                    + Environment.NewLine + "- To nie jedyne nasze zmartwienie " + this.nameTextBox.Text.Trim() + ". Obejrzyj się."
                    + Environment.NewLine + "- Morze!? Pojawiło się morze w środku dżungli!"
                    + Environment.NewLine + "- Tak i zalało nam drogę do kolejnego artefaktu."
                    + Environment.NewLine + "- Ale jak to możliwe? Skąd się w jednej chwili pojawiło morze w środku dżungli?!"
                    + Environment.NewLine + "- Możliwe, że ma to związek z trzęsieniami, które wywołał Strażnik Świątynni powstając i upadając. W każdym razie musimy teraz to morze przepłynąć."
                    + Environment.NewLine + "- Mam pomysł! Zbudujemy tratwę i  na niej przepłyniemy morze!"
                    + Environment.NewLine + "- Nie prościej bym wyczarował łódź?"
                    + Environment.NewLine + "- Haha, no tak przecież jesteś najpotężniejszym czarodziejem. Na pewno potrafisz wyczarować łódź!"
                    + Environment.NewLine + Environment.NewLine + "(Dżin pstryknął palcami i na brzegu dopiero co powstałego morza, pojawiła się łódź.)" + Environment.NewLine
                    + Environment.NewLine + "- Wskakuj i ruszamy!");
                afterSixthQuest = false;
                this.questButton.Enabled = false;
                sideQuestForm.updateSideQuestForm("Gonią Cię jaszczuroludzie! Uciekasz na morze czy zostajesz by walczyć?", "Walczę!", "Odpływam!",4);
                sideQuestForm.Show();
            }
            else if (afterSeventhQuest)
            {
                addTextToLogTextBox(Environment.NewLine + "(W walce z Krakenem z Podziemnego Oceanu została zniszczona Twoja łódź. Budzisz się na plaży.)" + Environment.NewLine
                    + Environment.NewLine + "- Wstawaj Dżinie, jesteśmy na plaży!"
                    + Environment.NewLine + "- Ta plaża jest częścią pustynni."
                    + Environment.NewLine + "- To źle?"
                    + Environment.NewLine + "- To bardzo dobrze! Jesteśmy na dobrej drodze po kolejny artefakt!");
                afterSeventhQuest = false;
            }
            else if (afterEightQuest)
            {
                string characterPower;
                if (checkClass() == "Mag")
                {
                    characterPower = "Moc";
                }
                else
                {
                    characterPower = "Siła";
                }
                addTextToLogTextBox(Environment.NewLine + "Chwilę mi zajęło, ale strażnik pokonany. Pozostało zabrać artefakt."
                    + Environment.NewLine + "- Przynajmniej tutaj nie ma świątynni, która może nam się zwalić na głowy."
                    + Environment.NewLine + "- Artefaktem jest dzbanek? Może jakiś dżin siedzi w środku? Haha."
                    + Environment.NewLine + "- Zapewniam Cię, że nie. W środku jest Woda Wzmocnienia, którą masz wypić by zyskać na sile."
                    + Environment.NewLine + Environment.NewLine + "(Wypijasz wodę z dzbanka. " + characterPower + " +100, życie +150, szczęście +10.)" + Environment.NewLine
                    + Environment.NewLine + "- Czuję się silniejszy!"
                    + Environment.NewLine + "- Oczywiście. Zwykłej wody nie strzegłby strażnik. Dzięki niej i amuletowi będziesz miał szansę z Tytanem Wulkanu."
                    + Environment.NewLine + "- Z kim?"
                    + Environment.NewLine + "- Nie powiedziałem Ci wcześniej? To on porwał księżniczkę."
                    + Environment.NewLine + "- Tytan Wulkanu... Nie brzmi zachęcająco, ale muszę mu stawić czoła.");
                this.dmgValueLabel.Text = (Convert.ToInt32(this.dmgValueLabel.Text) + 100).ToString();
                this.lifeValueLabel.Text = (Convert.ToInt32(this.lifeValueLabel.Text) + 150).ToString();
                this.luckValueLabel.Text = (Convert.ToInt32(this.luckValueLabel.Text) + 10).ToString();
                afterEightQuest = false;
                this.questButton.Enabled = false;
                sideQuestForm.updateSideQuestForm("W piasku leży jakiś dziwny niebieski kamień w pomarańczowe kropki."
                    + Environment.NewLine + "Podchodzisz by się mu bliżej przyjrzeć?", "Tak, każdy kamień jest ciekawy!", "Nie intersuję się kamieniami.",5);
                sideQuestForm.Show();
                mightyWaterForm.Show();
            }
            else if (afterNinthQuest)
            {
                addTextToLogTextBox(Environment.NewLine + "Gratulacje! Uratowałeś księżniczkę oraz ukończyłeś główną przygodę! Możesz szukać kolejnych, jeśli chcesz!");
                afterNinthQuest = false;
            }
            else
            {
                duringTheQuestOrFight = true;
                questButton.Enabled = false;
                useButton.Enabled = true;
                int characterLvl = Convert.ToInt32(this.lvlValueLabel.Text);
                int howManyMonsters = random.Next(1, characterLvl + 1);

                if (characterLvl <= 8)
                {
                    switch (characterLvl)
                    {
                        //Na 1 poziomie spotykamy tylko po jednym stworze na raz typu Monster.
                        case 1:
                            currentlyFigthingMonsters.Add(randomMonster(1, commonMonstersList));
                            fightingMonstersDescriptions();
                            break;
                        //Na 2 poziomie spotykamy losową ilość stworów typu Monster.
                        case 2:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(1, forestMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        //Na 3 poziomie spotykamy losową ilość stworów typów Monster i ArmoredMonster.
                        case 3:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(2, forestMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        //Na 4 poziomie spotykamy losową ilość stworów typów Monster, ArmoredMonster oraz LuckyMonster.
                        case 4:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(3, forestMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        //Od 5 do 9 poziomu spotykamy losową ilość stworów typów Monster, ArmoredMonster, LuckyMonster oraz BlockingMonster.
                        case 5:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(4, mountainMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        case 6:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(4, jungleMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        case 7:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(4, waterMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        case 8:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(4, desertMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                        case 9:
                            for (int i = 0; i < howManyMonsters; i++)
                            {
                                currentlyFigthingMonsters.Add(randomMonster(4, volcanoMonstersList));
                            }
                            fightingMonstersDescriptions();
                            break;
                    }
                    fillTargetComboBox();
                }
                else
                {
                    for (int i = 0; i < howManyMonsters; i++)
                    {
                        currentlyFigthingMonsters.Add(randomMonster(5, allMonstersList));
                    }
                    fightingMonstersDescriptions();
                    fillTargetComboBox();
                }
            }
        }

        /// <summary>
        /// Dodaje opisy stworów do logTextBox.
        /// </summary>
        private void fightingMonstersDescriptions()
        {
            addTextToLogTextBox(Environment.NewLine + currentlyFigthingMonsters[0].Description(true));
            if (currentlyFigthingMonsters.Count() >= 2)
            {
                addTextToLogTextBox("Tuż za tym stworem:");
            }
            for (int i = 1; i < currentlyFigthingMonsters.Count(); i++)
            {
                addTextToLogTextBox(currentlyFigthingMonsters[i].Description(false));
            }
        }

        private void sideQuest(int number)
        {
            switch (number)
            {
                case 1:
                    duringTheQuestOrFight = true;
                    questButton.Enabled = false;
                    useButton.Enabled = true;
                    addTextToLogTextBox(Environment.NewLine + "- Zobacz Dżinie w tym lesie grasują bandyci. Może to przez nich ta wioska opustoszała?"
                    + Environment.NewLine + "- Jeśli to ich sprawka, to lepiej się z nimi rozprawić nim zaatakują także Twoją wieś."
                    + Environment.NewLine + "- Zgadzam się."
                    + Environment.NewLine + Environment.NewLine + "(Zza krzaków wyskakują bandyci.)" + Environment.NewLine
                    + Environment.NewLine + "Słyszeliście to chłopaki? Te cherlaki chcą się z nami rozprawić! Brać ich!");
                    currentlyFigthingMonsters.Add(new Monster("Zwykły", "Bandycka Szumowina", 70, 40, 1));
                    currentlyFigthingMonsters.Add(new Monster("Zwykły", "Bandycka Szumowina", 90, 30, 2));
                    currentlyFigthingMonsters.Add(new Monster("Rzadki", "Drab", 130, 40, 2));
                    currentlyFigthingMonsters.Add(new Monster("Epicki", "Herszt Bandytów", 110, 40, 2));
                    addTextToLogTextBox(Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[1].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[2].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[3].Description(false));
                    fillTargetComboBox();
                    expForQuestComplete = 70;
                    firstSideQuest = false;
                    changeQuestButtonText("Szukaj przygód!");
                    break;
                case 2:
                    duringTheQuestOrFight = true;
                    questButton.Enabled = false;
                    threeCupsGameForm.Show();
                    addTextToLogTextBox(Environment.NewLine + "- Te potwory trzymały coś w klatce!"
                    + Environment.NewLine + "- Nie coś, tylko kogoś! Jestem Leśnym Skrzatem."
                    + Environment.NewLine + "- Skrzat, który mówi!"
                    + Environment.NewLine + "- Mówi i propnuje Ci grę, jeśli za trzema próbami zgadniesz pod którym kubkiem trzymam monetę przynoszącą szczęście, to będzie ona Twoja."
                    + Environment.NewLine + "- W porządku.");
                    secondSideQuest = false;
                    changeQuestButtonText("Szukaj przygód!");
                    break;
                case 3:
                    duringTheQuestOrFight = true;
                    questButton.Enabled = false;
                    useButton.Enabled = true;
                    currentlyFigthingMonsters.Add(new Monster("Rzadki", "Wilk", 450, 90, 3));
                    addTextToLogTextBox(Environment.NewLine + "Uwolniony wilk rzuca się na Ciebie i próbuje Cię ugryźć!"
                        + Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
                    fillTargetComboBox();
                    expForQuestComplete = 120;
                    thirdSideQuest = false;
                    changeQuestButtonText("Szukaj przygód!");
                    break;
                case 4:
                    duringTheQuestOrFight = true;
                    questButton.Enabled = false;
                    useButton.Enabled = true;
                    currentlyFigthingMonsters.Add(new BlockingMonster("Zwykły", "Jaszczuroczłek wojownik", 600, 150, 6, 300, 30, 1.3));
                    currentlyFigthingMonsters.Add(new BlockingMonster("Zwykły", "Jaszczuroczłek wojownik", 600, 150, 6, 300, 30, 1.3));
                    currentlyFigthingMonsters.Add(new BlockingMonster("Zwykły", "Jaszczuroczłek wojownik", 600, 150, 6, 300, 30, 1.3));
                    currentlyFigthingMonsters.Add(new BlockingMonster("Epicki", "Jaszczuroczłek mag", 600, 180, 6, 200, 50, 1.5));
                    currentlyFigthingMonsters.Add(new BlockingMonster("Legendarny", "Jaszczuroczłek przywódca", 600, 180, 6, 500, 60, 1.6));
                    addTextToLogTextBox(Environment.NewLine + "Jaszczuroludzie dogonili Cię! Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[1].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[2].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[3].Description(false));
                    addTextToLogTextBox(currentlyFigthingMonsters[4].Description(false));
                    fillTargetComboBox();
                    expForQuestComplete = 200;
                    fourthSideQuest = false;
                    changeQuestButtonText("Szukaj przygód!");
                    break;
                case 5:
                    duringTheQuestOrFight = true;
                    questButton.Enabled = false;
                    useButton.Enabled = true;
                    currentlyFigthingMonsters.Add(new Boss("Ultra mega legendarny", "Duży smok", 3500, 400, 9, 700, 50, 1.2, 150));
                    addTextToLogTextBox(Environment.NewLine + "Okazało się, że kamień to pobrudzone piaskiem smocze jajo! Nie wiesz jak się znalazło na pustynni, ale widzisz już Dużego smoka lecącego w Twoją stronę! Zaczynacie walkę!"
                        + Environment.NewLine + currentlyFigthingMonsters[0].Description(false));
                    fillTargetComboBox();
                    expForQuestComplete = 350;
                    fifthSideQuest = false;
                    changeQuestButtonText("Szukaj przygód!");
                    break;
            }
        }

        private void firstQuest()
        {
            nameTextBox.Enabled = false;
            classComboBox.Enabled = false;
            duringTheQuestOrFight = true;
            this.logTextBox.Text = "Wracając z pastwiska do domu, przy poboczu drogi, zauważasz dzbanek z dziwnymi wzorami."
                + Environment.NewLine + "Podnosząc postanawiasz przetrzeć go z kurzu, by móc się lepiej przyjrzeć wzorom." + Environment.NewLine;
            PotForm pot = new PotForm();
            pot.Show();
            this.wDmgValueLabel.Text = "5";
            this.questButton.Enabled = false;
        }

        private void secondQuest()
        {
            addTextToLogTextBox(Environment.NewLine + "- Myślałem, że sam będę podróżował."
            + Environment.NewLine + "- Przeszkadza Ci moje towarzystwo?"
            + Environment.NewLine + "- Jestem tylko ciekaw. Dżiny w opowieściach po spełnieniu życzeń wracają do lampy... lub dzbanka."
            + Environment.NewLine + "- Po uwolnieniu z dzbanka miałbym do niego wracać? Nigdy w życiu!"
            + Environment.NewLine + "- Byłeś uwięziony? Kto Cię uwięził?"
            + Environment.NewLine + "- Długa historia... lecz mamy kawał drogi przed sobą. Mag posiadał arcywroga, był nim najpotężniejszy czarownik na świecie. Sam z tego powodu był drugi, więc przyzwał mnie ze świata dżinów i wypowiedział życzenie: Zamknij najpotężniejszego na świecie czarodzieja w dzbanku! Oczywiście spełniłem jego życzenie."
            + Environment.NewLine + "- Czyli jak znalazłeś się w dzbanku?"
            + Environment.NewLine + "- Już wyjaśniłem, spełniłem jego życzenie."
            + Environment.NewLine + "- Ale jak znalazłeś się w dzbanku?!"
            + Environment.NewLine + "- Myślę, że zamiast o przygodę i księżniczkę powinieneś był poprosić o inteligencję.. Mag przyzywa mnie bym zamknął najpotężniejszego czarodzieja na świecie w dzbanku, bo sam nie posiada wystarczającej mocy, tak ?"
            + Environment.NewLine + "- Tak."
            + Environment.NewLine + "- Jeżeli jestem na tym świecie i mam moc by zamknąć najpotężniejszego czarodzieja na świecie, to kto jest najpotężniejszym czarodziejem na świecie?"
            + Environment.NewLine + "- Sam zamknąłeś się w dzbanku?!!"
            + Environment.NewLine + "- Tak! Zawsze spełniam wypowiedziane życzenie!"
            + Environment.NewLine + "- Wiesz dżinie, Tobie też trochę inteligencji by się przydało..."
            + Environment.NewLine + Environment.NewLine + "Poznałeś historię Dżina!");
            earnExp(100);
            addTextToLogTextBox(Environment.NewLine + "(Po chwili.)" + Environment.NewLine
            + Environment.NewLine + " -Zobacz, doszliśmy do opuszczonej wioski."
            + Environment.NewLine + "- Ciekawe dlaczego ludzie ją opuścili? Wokół tylko łąki i las. Wydaje się to dobre miejsce do życia."
            + Environment.NewLine + "- Może właśnie, to przez ten las. W lasach zawsze czają się jakieś niebezpieczne stwory."
            + Environment.NewLine + "- Wiesz jakie są w tym?"
            + Environment.NewLine + "- Nie wiem, ale zaraz się dowiemy, ponieważ nasza droga wiedze dokładnie przez środek tego lasu...");
            sideQuestForm.updateSideQuestForm("Na jednym z przydrożnych drzew wisi ostrzeżenie o bandytach grasujących w lesie."
                + Environment.NewLine + "Chcesz ich poszukać?", "Tak", "Nie",1);
            sideQuestForm.Show();
            this.questButton.Enabled = false;
        }

        private void thirdQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;

            //Dodanie stworów do listy aktualnie walczących.
            currentlyFigthingMonsters.Add(new ArmoredMonster("Rzadki", "Opancerzony " + randomMonsterName(forestMonstersList), 50, 50, 3, 80));
            currentlyFigthingMonsters.Add(new ArmoredMonster("Rzadki", "Opancerzony " + randomMonsterName(forestMonstersList), 50, 50, 3, 80));
            currentlyFigthingMonsters.Add(new ArmoredMonster("Epicki", "Ciężko opancerzony " + randomMonsterName(forestMonstersList), 50, 50, 3, 400));

            //Wyświetlenie treści zadania.
            addTextToLogTextBox(Environment.NewLine + "- Most na drugą stronę, przechodzimy?"
            + Environment.NewLine + "- Możemy przejść lub możesz zmierzyć się z Władcą tego Mrocznego Lasu, który tu widzimy. Masz już trochę doświadczenia z leśnymi potworami, więc powinieneś być w stanie go pokonać. Władca Lasu zamieszkał w nim jakieś 100 lat temu. Nie wiadomo skąd przybył, jednak wiadomo, że od tamtej pory drzewa w lesie zaczęły usychać, a zwierzęta powoli umierać. To jak? Idziemy mostem czy chcesz trochę powalczyć i być może nauczyć się czegoś nowego?"
            + Environment.NewLine + "- Przygód nigdy za wiele. Ruszajmy w las!"
            + Environment.NewLine + "- Tylko najpierw zajmij się jeszcze tą małą przeszkodą.");

            //Wyświetlenie opisu stworów.
            addTextToLogTextBox(Environment.NewLine + currentlyFigthingMonsters[0].Description(true));
            addTextToLogTextBox(currentlyFigthingMonsters[1].Description(false));
            addTextToLogTextBox(currentlyFigthingMonsters[2].Description(false));

            //Wywołanie metody uzupełniającej ComboBox wyboru celu nazwami stworów znajdujących się na liście aktualnie walczących.
            fillTargetComboBox();
            expForQuestComplete = 150;
            afterThirdQuest = true;
        }

        private void fourthQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            currentlyFigthingMonsters.Add(new ArmoredMonster("Legendarny", "Władca Mrocznego Lasu", 600, 100, 4, 50));
            addTextToLogTextBox(Environment.NewLine + "- Długo już idziemy..."
                + Environment.NewLine + "- Zgadzam się, jesteśmy już całkiem daleko w głąb Mrocznego Lasu, a Władcy jak nie było tak nie ma."
                + Environment.NewLine + "- Może go tu wcale nie ma?"
                + Environment.NewLine + "- Spójrz na te martwe drzewa, na uschniętą trawę. Uważasz, że to naturalny wygląd lasu?"
                + Environment.NewLine + "- Nie mówię, że nigdy Władcy tu nie było, ale że może sobie już poszedł?"
                + Environment.NewLine + "- Jeszcze nie cała roślinność obumarła. Sądzę, że nadal gdzieś tu jest."
                + Environment.NewLine + Environment.NewLine + "(Jakiś głos, nie wiadomo skąd.)" + Environment.NewLine
                + Environment.NewLine + "- Czego szuka Dżin w moim lesie?"
                + Environment.NewLine + "- Dżin niczego, ale ten tu " + checkClass() + " przybył nabrać trochę doświadczenia i na nieszczęście dla Ciebie będzie trenował na Tobie!"
                + Environment.NewLine + "- " + checkClass() + "? Ten pasterz owiec? Ledwie jest w stanie unieść swoją broń, ha ha! Skończy jako nawóz dla roślin, ha ha!"
                + Environment.NewLine + "- Od kiedy obchodzą Cię rośliny? Większa część lasu jest bez życia dzięki Tobie! - wtrąciłeś."
                + Environment.NewLine + "- Ha ha, masz rację młody pasterzu. Moja obecność wyjaławia ziemię. Im żyźniejsza, tym dłużej mogę żyć, a gdy całkiem się wyjałowi, to znajduję sobie kolejny las."
                + Environment.NewLine + "- Jesteś zarazą, która za chwilę dobiegnie końca!"
                + Environment.NewLine + Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
            fillTargetComboBox();
            expForQuestComplete = 250;
            afterFourthQuest = true;
        }

        private void fifthQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            addTextToLogTextBox(Environment.NewLine + "- Zrobiło się całkiem zimno. Brakuje tylko żeby śnieg zaczął padać."
                + Environment.NewLine + "- Nic dziwnego, weszliśmy już całkiem wysoko."
                + Environment.NewLine + "- Mostu wciąż nie widać, ba nawet rzeki lub dżungli."
                + Environment.NewLine + "- Nie masz co narzekać. Jak dotąd podróż przez góry była dość spokojna."
                + Environment.NewLine + "- Nie licząc kilku potworów, które musiałem pokonać."
                + Environment.NewLine + "- Przecież nie sprawiły Ci trudności. Nie ma co o nich wspominać. Prawdziwe potwory dopiero spotkasz i miej nadzieję, że nie będzie wśród nich Pani Zamieci."
                + Environment.NewLine + Environment.NewLine + "(Zaczął padać gęsty śnieg i wiać silny wiatr.)" + Environment.NewLine
                + Environment.NewLine + "- Sprawiasz Dżinie wrażenie jakbyś się jej bał, a nie wiemy czy na pewno istnieje."
                + Environment.NewLine + "- Nie boję się niczego, ale nie mam chęci walczyć z tak potężnym przeciwnikiem jeżeli nie muszę."
                + Environment.NewLine + Environment.NewLine + "(Opady przemieniły się w zamieć.)" + Environment.NewLine
                + Environment.NewLine + "- Haha, jak się pojawi, to ją po prostu pokonam!"
                + Environment.NewLine + "- " + this.nameTextBox.Text.Trim() + "."
                + Environment.NewLine + "- Nic się nie martw, na pewno dam radę!"
                + Environment.NewLine + "- " + this.nameTextBox.Text.Trim() + "!"
                + Environment.NewLine + "- Nie krzycz, o co chodzi?"
                + Environment.NewLine + "- Ona stoi za Tobą..."
                + Environment.NewLine + Environment.NewLine + "Ultra mega legendarny Pani Zamieci lvl 50 z życiem 99999 i szansą na blok 99,99%. Blokuje 5000 obrażeń." + Environment.NewLine
                + Environment.NewLine + "- Szukałeś mnie " + checkClass() + "u?"
                + Environment.NewLine + "- ..."
                + Environment.NewLine + "- Usłyszałam, że chcesz mnie pokonać?"
                + Environment.NewLine + Environment.NewLine + "(Zbierasz w sobie odwagę.)" + Environment.NewLine
                + Environment.NewLine + "- ... yy Dżinie?"
                + Environment.NewLine + "- Życzyłeś sobie przygody? Oto jest! Powodzenia!"
                + Environment.NewLine + "- To nie pora na żarty! Będę potrzebował Twojej pomocy!"
                + Environment.NewLine + "- Uprzedzałem Cię byś lepiej jej nie spotkał!"
                + Environment.NewLine + "- Przecież nie miałem na to wpływu! Pojawiła się znikąd!"
                + Environment.NewLine + "- Może gdybyś nie był tak pewny siebie i się nie wydzierał, że ją pokonasz, to by się nie pojawiła!"
                + Environment.NewLine + "- Cisza! Widzę młody " + checkClass() + "u, że pomimo ujrzenia mojej potęgi jesteś gotów ze mną walczyć. Oczywiście nie masz szans, ale nie przejmuj się, nie będziemy walczyć i być może ujdziesz z życiem. O ile przejdziesz próbę."
                + Environment.NewLine + "- Jaką próbę? Po co?"
                + Environment.NewLine + "- Dostarczysz mi trochę rozrywki młody " + checkClass() + "u. Twoim zadaniem będzie pokonanie wybranych przeze mnie potworów.");
            currentlyFigthingMonsters.Add(new BlockingMonster("Epicki", "Lodowy gigant", 500, 130, 5, 100, 30, 1.3));
            currentlyFigthingMonsters.Add(new BlockingMonster("Epicki", "Górski olbrzym", 400, 80, 5, 100, 5, 1.8));
            currentlyFigthingMonsters.Add(new BlockingMonster("Epicki", "Yeti", 400, 100, 5, 130, 60, 1.2));
            addTextToLogTextBox(Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
            addTextToLogTextBox(currentlyFigthingMonsters[1].Description(false));
            addTextToLogTextBox(currentlyFigthingMonsters[2].Description(false));
            fillTargetComboBox();
            afterFifthQuest = true;
            expForQuestComplete = 350;
        }

        private void sixthQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            currentlyFigthingMonsters.Add(new Boss("Ultra mega legendarny", "Strażnik Świątynni Kamienny Goryl", 1500, 200, 8, 100, 33, 1.4, 50));
            addTextToLogTextBox(Environment.NewLine + "- Dotarliśmy na miejsce. Oto świątynia Jaszczuroludzi."
                + Environment.NewLine + "- Imponująca, lecz spodziewałem się strażników."
                + Environment.NewLine + "- Tu się z Tobą zgodzę. W każdej legendzie o amulecie Jaszczuroludzi była mowa o potężnych strażnikach lub strażniku broniącym wejścia do świątynni, a tymczasem nikogo tu nie widać."
                + Environment.NewLine + "- Podejrzane. Bardzo podejrzane. To musi być pułapka."
                + Environment.NewLine + "- Nie mamy wyjścia. Amulet jest niezbędny jeżeli chcesz odbić księżniczkę."
                + Environment.NewLine + "- Jeżeli wejdziemy w głąb świątynni, to Jaszczuroludzie mogą się zebrać i czekać na nas u jej wyjścia, ale wówczas powinienem sobie z nimi poradzić. Nawet gorzej dla nich jeżeli czekają wewnątrz, więc jaką mogli zastawić pułapkę? Cóż, chyba się nie dowiemy dopóki w nią nie wpadniemy..."
                + Environment.NewLine + Environment.NewLine + "(Po dłuższej chwili błądzenia po korytarzach znajdujecie salę z amuletem.)" + Environment.NewLine
                + Environment.NewLine + "- Nareszcie go znaleźliśmy."
                + Environment.NewLine + "- Bierz go i się stąd wynośmy. Mam złe przeczucia co do tego miejsca..."
                + Environment.NewLine + Environment.NewLine + "(Podnosisz amulet. Świątynia zaczyna się trząść i rozpadać.)" + Environment.NewLine
                + Environment.NewLine + "- Jest i pułapka! Zostaniemy pogrzebani w ruinach tej świątynni!"
                + Environment.NewLine + "- Nie gadaj tylko biegnij! Czekaj! Jednak stój!"
                + Environment.NewLine + "- Zdecyduj się Dżinie!"
                + Environment.NewLine + "- Popatrz! Ściany się nie rozpadają, one się podnoszą!"
                + Environment.NewLine + "- Co tu się dzieje!?"
                + Environment.NewLine + Environment.NewLine + "(Część ścian została na swoim miejscu, część się przesunęła, a część się podniosła. Wszystkie razem uformowały gigantycznego Kamiennego Goryla.)" + Environment.NewLine);
            addTextToLogTextBox("Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
            fillTargetComboBox();
            amuletForm.Show();
            afterSixthQuest = true;
            expForQuestComplete = 450;
        }

        private void seventhQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            currentlyFigthingMonsters.Add(new Monster("Zwykły", "Macka", 500, 200, 9));
            currentlyFigthingMonsters.Add(new ArmoredMonster("Rzadki", "Opancerzona Macka", 500, 200, 9, 200));
            currentlyFigthingMonsters.Add(new LuckyMonster("Epicki", "Krytyczna Macka", 500, 200, 9, 50, 1.5));
            currentlyFigthingMonsters.Add(new BlockingMonster("Legendarny", "Blokująca Macka", 500, 200, 9, 300, 30, 1.2));
            currentlyFigthingMonsters.Add(new Boss("Ultra mega legendarny", "Kraken z Podziemnego Oceanu", 2000, 300, 9, 400, 33, 1.4, 80));
            addTextToLogTextBox(Environment.NewLine + "(Coś szybko przeleciało Ci przed oczami.)" + Environment.NewLine
                + Environment.NewLine + "- Dżinie, chyba widziałem mackę."
                + Environment.NewLine + "- Mackę?"
                + Environment.NewLine + "- Tak, mackę. Taką, jakie mają ośmiornice, tylko większą."
                + Environment.NewLine + "- Jeżeli w miejscu dżungli może pojawić się morze, to nie wykluczone, że pojawiła się też macka, ale może to była jakaś ryba?"
                + Environment.NewLine + "- Sądzę, że jednak to była macka."
                + Environment.NewLine + "- Jeżeli to nie była macka dużej ośmiornicy, to kolejnym wyjaśnieniem byłby potwór morski..."
                + Environment.NewLine + Environment.NewLine + "(Macka znów się wyłania z wody, a za nią reszta ciała potwora morskiego.)" + Environment.NewLine
                + Environment.NewLine + "- Jestem Kraken władca tego morza!"
                + Environment.NewLine + "- Jednak macka należała do potwora. Zostawiam go Tobie " + this.nameTextBox.Text.Trim() + "."
                + Environment.NewLine + "- Nie możesz być władcą tego morza, ponieważ ono dopiero co powstało!"
                + Environment.NewLine + "- Miałeś walczyć, a nie prowadzić dyskusję ..."
                + Environment.NewLine + "- Muszę to z nim wyjaśnić. Przez nas powstało to morze, a on je sobie przywłaszczył! Słyszysz Krakenie?! To moje morze! Wynoś się z niego!"
                + Environment.NewLine + "- Śmieszny człowieczku! Nie wiesz z kim zadarłeś! Jestem Kraken, najsilniejszy potwór z Podziemnego Oceanu! Trzęsienie stworzyło wyrwę w ziemi przez którą wraz z wodą dostałem się na powierzchnię!"
                + Environment.NewLine + "- To by wiele wyjaśniało... Niemniej, to my spowodowaliśmy trzęsienie, a bez niego nie byłoby wyrwy!"
                + Environment.NewLine + "- Giń człowieku!"
                + Environment.NewLine + Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false)
                + Environment.NewLine + currentlyFigthingMonsters[1].Description(false)
                + Environment.NewLine + currentlyFigthingMonsters[2].Description(false)
                + Environment.NewLine + currentlyFigthingMonsters[3].Description(false));
            addTextToLogTextBox(currentlyFigthingMonsters[4].Description(false));
            fillTargetComboBox();
            afterSeventhQuest = true;
            expForQuestComplete = 500;
        }

        private void eighthQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            currentlyFigthingMonsters.Add(new Boss("Ultra mega legendarny", "Pisakowy Człowiek Strażnik Wody Wzmocnienia", 4000, 350, 10, 500, 33, 1.3, 150));
            addTextToLogTextBox(Environment.NewLine + "- Widzę jakiś prostokątny kamień w oddali!"
                + Environment.NewLine + "- Możliwe, że to ołtarz którego szukamy."
                + Environment.NewLine + Environment.NewLine + "(Minęła godzina.)" + Environment.NewLine
                + Environment.NewLine + "- W ogóle się nie zbliżamy. Ołtarz jest cały czas tak samo daleko."
                + Environment.NewLine + "- Masz rację. Sprawdzę coś."
                + Environment.NewLine + Environment.NewLine + "(Dżin podniósł rękę ku górze, chwycił powietrze, a następnie mocno szarpnął w dół. Ołtarz pojawił się tuż obok nich, ale pobliskie wydmy zaczęły się do siebie zbliżać i łączyć.)" + Environment.NewLine
                + Environment.NewLine + "- Słusznie przypuszczałem, to była iluzja!"
                + Environment.NewLine + "- Dżinie! Coś się dzieje z wydmami!"
                + Environment.NewLine + "- To najpewniej strażnik."
                + Environment.NewLine + "- Nie mówiłeś, że będzie jakiś strażnik!"
                + Environment.NewLine + "- Potężnych artefaktów zawsze chronią strażnicy. Myślałem, że wiesz."
                + Environment.NewLine + Environment.NewLine + "(Wydmy uformowały ogromnego Piaskowego Człowieka.)" + Environment.NewLine
                + Environment.NewLine + "- Kto próbuje ukraść mój skarb?!");
            addTextToLogTextBox(Environment.NewLine + "Zaczynasz walke z " + currentlyFigthingMonsters[0].Description(false));
            fillTargetComboBox();
            afterEightQuest = true;
            expForQuestComplete = 600;
        }

        private void ninthQuest()
        {
            duringTheQuestOrFight = true;
            questButton.Enabled = false;
            useButton.Enabled = true;
            currentlyFigthingMonsters.Add(new Boss("Ultra mega legendarny", "Tytan wulkanu", 10000, 450, 12, 1000, 60, 1.3, 200));
            addTextToLogTextBox(Environment.NewLine + "Jesteśmy już prawie na szczycie, więc Dżinie wyjaśnij mi jaki mamy plan."
                + Environment.NewLine + "- Nic trudnego... na początku. Pierwszym krokiem jest wrzucenie amuletu do lawy wewnątrz wulka..."
                + Environment.NewLine + "- Mam wyrzucić z takim trudem zdobyty amulet?!!!"
                + Environment.NewLine + "- Już Ci kiedyś powiedziałem. Nie przerywaj. Stoimy w tej chwili na Twoim kolejnym przeciwniku..."
                + Environment.NewLine + "- STOIMY NA TYTANIE WULKANU?!!!"
                + Environment.NewLine + "- ..."
                + Environment.NewLine + "- ... przepraszam, że przerwałem."
                + Environment.NewLine + "- Stoimy na Tytanie Wulkanu, gdyż on jest wulkanem. Gdzieś wewnątrz jaskini u szczytu trzyma księżniczkę. Po jego pokonaniu będziemy mogli jej w spokoju poszukać."
                + Environment.NewLine + Environment.NewLine + "Ultra mega legendarny Tytan Wulkanu lvl 100 z życiem 1 Milion. Potrafi uderzyć krytycznie. Szansa 100%. Mnożnik 1000%. Potrafi zablokować 10 000 obrażeń. Posiada pancerz 1 Milion." + Environment.NewLine
                + Environment.NewLine + "- Niedobrze. Przebudził się! Wrzuć szybko Amulet Osłabienia do lawy! To znacznie zmniejszy jego niewyobrażalną potęgę!"
                + Environment.NewLine + Environment.NewLine + "(Wrzucasz Amulet do wnętrza Tytana Wulkanu. Tytan słabnie.)" + Environment.NewLine
                + Environment.NewLine + "- Amulet zadziałał! Tytan ZNACZNIE osłabł!"
                + Environment.NewLine + "- Oczywiście, przecież mówiłem. Teraz masz z nim szansę.");
            addTextToLogTextBox(Environment.NewLine + "Zaczynasz walkę z " + currentlyFigthingMonsters[0].Description(false));
            fillTargetComboBox();
            afterNinthQuest = true;
            expForQuestComplete = 900;
        }

        /// <summary>
        /// Przyznaje nowy ekwipunek.
        /// </summary>
        /// <param name="monsterRarity"></param>
        /// <param name="monsterLvl"></param>
        private void lookForLoot(string monsterRarity, int monsterLvl)
        {
            int luckInfluence = Convert.ToInt32(this.luckValueLabel.Text) / 3;
            //60% na znalezienie czegokolwiek, powiększone o wpływ szczęścia
            if (random.Next(0, 101) < 60 + luckInfluence)
            {
                int newItemPoints = itemRarity(monsterRarity) * monsterLvl;
                //30% na znalezienie broni i 70% na znalezienie części pancerza 
                if (random.Next(0, 101) < 30)
                {
                    int oldWeaponDmg = Convert.ToInt32((this.wDmgValueLabel.Text));
                    if (checkIfBetter("Broń", oldWeaponDmg, newItemPoints))
                    {
                        this.wDmgValueLabel.Text = newItemPoints.ToString();
                    }
                }
                else
                {
                    //Którą część pancerza znajduję
                    switch (random.Next(0, 4))
                    {
                        case 0:
                            int oldHelmetArmor = Convert.ToInt32(this.helmetValueLabel.Text);
                            if (checkIfBetter("Hełm", oldHelmetArmor, newItemPoints))
                            {
                                this.helmetValueLabel.Text = newItemPoints.ToString();
                            }
                            break;
                        case 1:
                            int oldBreastplateArmor = Convert.ToInt32(this.breastplateValueLabel.Text);
                            if (checkIfBetter("Napierśnik", oldBreastplateArmor, newItemPoints))
                            {
                                this.breastplateValueLabel.Text = newItemPoints.ToString();
                            }
                            break;
                        case 2:
                            int oldGlovesArmor = Convert.ToInt32(this.glovesValueLabel.Text);
                            if (checkIfBetter("Rękawice", oldGlovesArmor, newItemPoints))
                            {
                                this.glovesValueLabel.Text = newItemPoints.ToString();
                            }
                            break;
                        case 3:
                            int oldBootsArmor = Convert.ToInt32(this.bootsValueLabel.Text);
                            if (checkIfBetter("Buty", oldBootsArmor, newItemPoints))
                            {
                                this.bootsValueLabel.Text = newItemPoints.ToString();
                            }
                            break;
                    }
                }
            }
            else
            {
                addTextToLogTextBox("Stwór nie miał przy sobie żadnych przedmiotów.");
            }
        }

        /// <summary>
        /// Sprawdza czy przesłany przedmiot jest lepszy od obecnego.
        /// </summary>
        /// <param name="itemName"></param>
        private bool checkIfBetter(string itemName, int oldItemPoints, int newItemPoints)
        {
            if (newItemPoints > oldItemPoints)
            {
                addTextToLogTextBox("Znalazłeś nową część ekwipunku! " + itemName
                    + "! Obecna wartość punktów przedmiotu: " + oldItemPoints + ". Nowa: " + newItemPoints
                    + ". Bierzesz przedmiot ze sobą!");
                return true;
            }
            else
            {
                addTextToLogTextBox("Znalazłeś nową część ekwipunku! " + itemName
                    + "! Obecna wartość punktów przedmiotu: " + oldItemPoints + ". Nowa: " + newItemPoints
                    + "! Niestety, ten przedmiot nie jest lepszy od Twojego obecnego, więc go porzucasz.");
                return false;
            }
        }

        /// <summary>
        /// Losuje wartość punktów przedmiotu zależnie od rzadkości potwora.
        /// </summary>
        /// <param name="monsterRarity"></param>
        /// <returns></returns>
        private int itemRarity(string monsterRarity)
        {
            int itemTier = 0;
            switch (monsterRarity)
            {
                case "Zwykły":
                    itemTier = random.Next(1, 6);
                    break;
                case "Rzadki":
                    itemTier = random.Next(6, 11);
                    break;
                case "Epicki":
                    itemTier = random.Next(11, 16);
                    break;
                case "Legendarny":
                    itemTier = random.Next(16, 21);
                    break;
                case "Ultra mega legendarny":
                    itemTier = random.Next(21, 31);
                    break;
            }
            return itemTier;
        }

        /// <summary>
        /// Przyznaje doświadczenie zależnie od typu i rzadkości stwora.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        private void earnExp(Monster monster)
        {
            int yourActualExp = Convert.ToInt32(this.expValueLabel.Text);
            int expFromRarity = this.expFromRarity(monster.Rarity);
            int earnedExp = 0;
            if (monster is Boss)
            {
                earnedExp = 30 + expFromRarity;
                yourActualExp += earnedExp;
            }
            else if (monster is ArmoredMonster || monster is LuckyMonster)
            {
                earnedExp = 10 + expFromRarity;
                yourActualExp += earnedExp;
            }
            else if (monster is BlockingMonster)
            {
                earnedExp = 15 + expFromRarity;
                yourActualExp += earnedExp;
            }
            else
            {
                earnedExp = 5 + expFromRarity;
                yourActualExp += earnedExp;
            }
            this.expValueLabel.Text = yourActualExp.ToString();
            addTextToLogTextBox("Zdobywasz " + earnedExp + " doświadczenia!");
        }

        /// <summary>
        /// Przyznaje konkretną wartość doświadczenia.
        /// </summary>
        /// <param name="newExp"></param>
        public void earnExp(int newExp)
        {
            int yourActualExp = Convert.ToInt32(this.expValueLabel.Text);
            this.expValueLabel.Text = (yourActualExp + newExp).ToString();
            addTextToLogTextBox("Zdobywasz " + newExp + " doświadczenia za ukończenie zadania!");
        }

        /// <summary>
        /// Sprawdza rzadkość potwora i zwraca przypisaną jej wartość.
        /// </summary>
        /// <param name="rarity"></param>
        /// <returns></returns>
        private int expFromRarity(string rarity)
        {
            int rarityValue = 0;
            switch (rarity)
            {
                case "Zwykły":
                    rarityValue = 5;
                    break;
                case "Rzadki":
                    rarityValue = 10;
                    break;
                case "Epicki":
                    rarityValue = 15;
                    break;
                case "Legendarny":
                    rarityValue = 20;
                    break;
                case "Ultra mega legendarny":
                    rarityValue = 40;
                    break;
            }
            return rarityValue;
        }

        /// <summary>
        /// Losuje potwora, a jego nazwa jest z listy powszechnych potworow lub listy nazw danego obszaru.
        /// </summary>
        /// <param name="monstersList"></param>
        /// <returns></returns>
        private Monster randomMonster(int howManyTypes, List<string> monstersNamesFromSpecificArea)
        {
            List<string> currentMonstersNames = new List<string>();
            int characterLvl = Convert.ToInt32(this.lvlValueLabel.Text);
            int minMonsterLvl = characterLvl - 3;
            if (minMonsterLvl <= 0)
            {
                minMonsterLvl = 1;
            }
            int monsterLvl = random.Next(minMonsterLvl, characterLvl + 1);
            int monsterLife = random.Next(40, 101) * monsterLvl;
            int monsterPower = random.Next(15, 41) * monsterLvl;
            int monsterArmor = random.Next(10, 36) * monsterLvl;
            int monsterLuck = random.Next(5, 71);
            //losowy double z przedziału 1,1 -1,5 zaokrąglony do 1 miejsca po przecinku
            double monsterCritDmgMultiplier = Math.Round(random.NextDouble() * (1.5 - 1.1) + 1.1, 1);
            int monsterBlock = random.Next(10, 81) * monsterLvl;
            string monsterRarity;
            int r = random.Next(0, 100);
            if (r < 50)
            {
                monsterRarity = "Zwykły";
            }
            else if (r >= 50 && r < 75)
            {
                monsterRarity = "Rzadki";
            }
            else if (r >= 75 && r < 90)
            {
                monsterRarity = "Epicki";
            }
            else if (r >= 90 && r < 98)
            {
                monsterRarity = "Legendarny";
            }
            else
            {
                monsterRarity = "Ultra mega legendarny";
            }

            //Jeden typ stwora będzie dostępny na samym początku gry, wówczas jako parametr typu List<string>
            //będzie przesłana lista commonMonsters, a w sytuacji 5 typow (pod koniec gry) będzie przesłana lista
            //wszystkich nazw stworów. We wszystkich pośrednich przypadkach będzie przesyłana lista nazw stworów 
            //z danego obszaru i łączona z listą stworów powszechnych. Dzięki takiej liście na obszarze lasu 
            //będą losowane nazwy stworów leśnych i zwykłych, na obszarze pustynni, pustynne i zwykłe itd. 
            if (howManyTypes == 1 || howManyTypes == 5)
            {
                foreach (var name in monstersNamesFromSpecificArea)
                {
                    currentMonstersNames.Add(name);
                }
            }
            else
            {
                currentMonstersNames = commonMonstersList.Concat(monstersNamesFromSpecificArea).ToList();
            }
            //Lista przeskalowanych i predefiniowanych stworów z których losowany jest jeden.
            List<Monster> monstersTypesList = new List<Monster>() {
                    new Monster(monsterRarity, randomMonsterName(currentMonstersNames), monsterLife, monsterPower, monsterLvl),
                    new ArmoredMonster(monsterRarity, randomMonsterName(currentMonstersNames), monsterLife, monsterPower, monsterLvl,monsterArmor),
                    new LuckyMonster(monsterRarity, randomMonsterName(currentMonstersNames), monsterLife, monsterPower, monsterLvl,monsterLuck,monsterCritDmgMultiplier),
                    new BlockingMonster(monsterRarity, randomMonsterName(currentMonstersNames), monsterLife, monsterPower, monsterLvl,monsterBlock,monsterLuck,monsterCritDmgMultiplier),
                    new Boss(monsterRarity, randomMonsterName(currentMonstersNames), monsterLife, monsterPower, monsterLvl,monsterBlock,monsterLuck,monsterCritDmgMultiplier,monsterArmor)
            };
            return monstersTypesList[random.Next(0, howManyTypes)];
        }

        /// <summary>
        /// Metoda losuje imię potwora.
        /// </summary>
        /// <param name="monstersList"></param>
        /// <returns></returns>
        private string randomMonsterName(List<string> monstersList)
        {
            return monstersList[random.Next(0, monstersList.Count())];
        }

        /// <summary>
        /// Uzupełnia targetComboBox nazwami stworów.
        /// </summary>
        private void fillTargetComboBox()
        {
            foreach (Monster monster in currentlyFigthingMonsters)
            {
                this.targetComboBox.Items.Add(monster.Name);
            }
            this.targetComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Wczytuje ostatni zapisany stan gry oraz informuje o zginięciu postaci.
        /// </summary>
        private void loadCharacter()
        {
            this.characterTableAdapter.Fill(this.gameDBDataSet.Character);
            changeThingsToActualSave();
            duringTheQuestOrFight = false;
            firstSideQuest = false;
            secondSideQuest = false;
            thirdSideQuest = false;
            fourthSideQuest = false;
            fifthSideQuest = false;
            afterFourthQuest = false;
            afterFifthQuest = false;
            afterSixthQuest = false;
            afterSeventhQuest = false;
            afterEightQuest = false;
            afterNinthQuest = false;
            questButton.Enabled = true;
            useButton.Enabled = false;
            logTextBox.Text = "";
            skillsComboBox.Text = "";
            targetComboBox.Text = "";
            targetComboBox.Items.Clear();
            currentlyFigthingMonsters.Clear();
            MessageBox.Show("Twoja postać zginęła! Został wczytany ostatni zapis gry (jeśli istniał).", "Zostałeś pokonany!");
        }

        /// <summary>
        /// Dodaje tekst do logTextBox oraz ustawia na nim scrollbar.
        /// </summary>
        /// <param name="text"></param>
        public void addTextToLogTextBox(string text)
        {
            this.logTextBox.AppendText(Environment.NewLine + text);
        }

        /// <summary>
        /// Zmienia tekst przycisku questButton.
        /// </summary>
        public void changeQuestButtonText(string tekst)
        {
            this.questButton.Text = tekst;
        }

        /// <summary>
        /// Metoda zmieniająca tło przycisku, by zwrócić na niego uwagę gracza.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void questButtonBlink()
        {
            Color defaultQuestButtonColor = this.questButton.BackColor;

            for (int i = 0; i < 3; i++)
            {
                this.questButton.BackColor = Color.Yellow;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
                this.questButton.BackColor = defaultQuestButtonColor;
                Application.DoEvents();
                System.Threading.Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Zwraca jaką klasę wybrał gracz.
        /// </summary>
        /// <returns></returns>
        public string checkClass()
        {
            if (classComboBox.Text.Trim() == "Wojownik")
            {
                return "Wojownik";
            }
            else
            {
                return "Mag";
            }
        }

        /// <summary>
        /// Zwiększa wartość szczęścia o podaną ilość.
        /// </summary>
        /// <param name="howMuch"></param>
        public void addLuck(int howMuch)
        {
            this.luckValueLabel.Text = (Convert.ToInt32(this.luckValueLabel.Text) + howMuch).ToString();
            addTextToLogTextBox(Environment.NewLine + "Otrzymujesz +" + howMuch + " do szczęścia!");
        }

        /// <summary>
        /// Sprawdza czy postać posiada wystarczającą ilość doświadczenia by otrzymać nowy poziom, a także przyznaje
        /// związane z tym profity.
        /// </summary>
        private void checkForLvlUp()
        {
            int currentExp = Convert.ToInt32(this.expValueLabel.Text);
            string currentLvl = this.lvlValueLabel.Text.Trim();
            if (currentExp >= 100 && currentLvl == "1")
            {
                this.lvlValueLabel.Text = "2";
                this.BackgroundImage = Properties.Resources._2;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL2;
                this.skillsComboBox.Items.Add("Leczenie");
                addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś sie nowej umiejętności Leczenie!");
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Opuszczona Wioska!", "Nowe miejsce!");
            }
            else if (currentExp >= 335 && currentLvl == "2")
            {
                this.lvlValueLabel.Text = "3";
                this.BackgroundImage = Properties.Resources._3;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL3;
                if (this.classComboBox.Text.Trim() == "Wojownik")
                {
                    this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Strzaskanie pancerza!");
                }
                else
                {
                    this.skillsComboBox.Items.Add("Klątwa rdzy");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Klątwa rdzy!");
                }
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Most przed Mrocznym Lasem!", "Nowe miejsce!");
            }
            else if (currentExp >= 700 && currentLvl == "3")
            {
                this.lvlValueLabel.Text = "4";
                this.BackgroundImage = Properties.Resources._4;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL4;
                if (this.classComboBox.Text.Trim() == "Wojownik")
                {
                    this.skillsComboBox.Items.Add("Tornado ostrzy");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Tornado ostrzy!");
                }
                else
                {
                    this.skillsComboBox.Items.Add("Fala ognia");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Fala ognia!");
                }
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Gęsty Mroczny Las!", "Nowe miejsce!");
            }
            else if (currentExp >= 1265 && currentLvl == "4")
            {
                this.lvlValueLabel.Text = "5";
                this.BackgroundImage = Properties.Resources._5;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL5;
                if (this.classComboBox.Text.Trim() == "Wojownik")
                {
                    this.skillsComboBox.Items.Add("Okrzyk bojowy");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Okrzyk bojowy!");
                }
                else
                {
                    this.skillsComboBox.Items.Add("Klątwa pecha");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Klątwa pecha!");
                }
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Szczyty gór!", "Nowe miejsce!");
            }
            else if (currentExp >= 1995 && currentLvl == "5")
            {
                this.lvlValueLabel.Text = "6";
                this.BackgroundImage = Properties.Resources._6;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL6;
                addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!");
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Dżungla!", "Nowe miejsce!");
            }
            else if (currentExp >= 2890 && currentLvl == "6")
            {
                this.lvlValueLabel.Text = "7";
                this.BackgroundImage = Properties.Resources._7;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL7;
                this.skillsComboBox.Items.Add("Większe leczenie");
                addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Większe leczenie!");
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Morze Krakena!", "Nowe miejsce!");
            }
            else if (currentExp >= 3900 && currentLvl == "7")
            {
                this.lvlValueLabel.Text = "8";
                this.BackgroundImage = Properties.Resources._8;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL8;
                if (this.classComboBox.Text.Trim() == "Wojownik")
                {
                    this.skillsComboBox.Items.Add("Cięcie wichru");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Cięcie wichru!");
                }
                else
                {
                    this.skillsComboBox.Items.Add("Kula ognia");
                    addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!" + Environment.NewLine + "Nauczyłeś się nowej umiejętności Kula ognia!");
                }
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Pustynia!", "Nowe miejsce!");
            }
            else if (currentExp >= 5075 && currentLvl == "8")
            {
                this.lvlValueLabel.Text = "9";
                this.BackgroundImage = Properties.Resources._9;
                mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL9;
                addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!");
                lvlUp();
                this.mapForm.Show();
                MessageBox.Show("Wulkan!", "Nowe miejsce!");
            }
            //Od tego momentu każde doświadczenie potrzebne do awansu na kolejny lvl jest opisane za pomocą 
            //ciągu geometrycznego.
            else
            {   //nie ma potrzeby przeprowadzania poniższych obliczeń za każdym razem poniżej poziomu 9
                if (Convert.ToInt32(currentLvl) >= 9)
                {
                    //q
                    double commonRatio = 1.2;
                    //a1
                    int scaleFactor = 7000;
                    //Odjąłem 8 początkowych lvli, by otrzymać n startowe równe 1
                    int n = Convert.ToInt32(currentLvl) - 8;
                    //n-ty wyraz ciągu: a1*q^(n-1)
                    int expToNextLvl = Convert.ToInt32(Math.Floor(scaleFactor * (Math.Pow(commonRatio, n - 1))));
                    if (currentExp >= expToNextLvl && currentLvl == (n + 8).ToString())
                    {
                        this.lvlValueLabel.Text = (n + 9).ToString();

                        //78 jest maksymalnym poziomem, ponieważ do zdobycia 79 wartość int zmiennej doświadczenia (2 442 222 699)
                        //przekroczyłaby swój zakres 2 147 483 647. Doświadczenie na 78 poziomie wynosi 2 035 185 582.
                        if (this.lvlValueLabel.Text == "78")
                        {
                            addTextToLogTextBox(Environment.NewLine + "Awansujesz na maksymalny 78 poziom!" + Environment.NewLine + "Nie możesz już zdobyć więcej doświadczenia!");
                        }
                        else
                        {
                            addTextToLogTextBox(Environment.NewLine + "Awansujesz na kolejny poziom!");
                            lvlUp();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Przyznaje punkty do statystyk za zdobycie poziomu.
        /// </summary>
        private void lvlUp()
        {
            int life = Convert.ToInt32(this.lifeValueLabel.Text);
            int power = Convert.ToInt32(this.dmgValueLabel.Text);
            int luck = Convert.ToInt32(this.luckValueLabel.Text);
            if (checkClass() == "Mag")
            {
                life += 50;
                power += 30;
                luck += 3;
                addTextToLogTextBox("Życie +50!" + Environment.NewLine + "Moc +30!" + Environment.NewLine + "Szczęśćie +3!");
            }
            else
            {
                life += 75;
                power += 15;
                luck += 1;
                addTextToLogTextBox("Życie +75!" + Environment.NewLine + "Siła +15!" + Environment.NewLine + "Szczęśćie +1!");
            }
            this.lifeValueLabel.Text = life.ToString();
            this.maxCharacterLife = life.ToString();
            this.dmgValueLabel.Text = power.ToString();
            this.luckValueLabel.Text = luck.ToString();
        }

        /// <summary>
        /// Po zmianie zapisu ustawia odpowiednią mapę, czary, tło.
        /// </summary>
        private void changeThingsToActualSave()
        {
            this.skillsComboBox.Text="";
            this.skillsComboBox.Items.Clear();
            string lvl = this.lvlValueLabel.Text.Trim();
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
            if (checkClass() == "Mag")
            {
                this.powerLabel.Text = "Moc:";
                switch (lvl)
                {
                    //Przypadek, gdy gracz wcześniej nie zapisał postepu, a zginął.
                    case "":
                        bindingNavigatorAddNewItem.Enabled = true;
                        useButton.Enabled = false;
                        this.BackgroundImage = Properties.Resources._1;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL1;
                        break;
                    case "1":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.BackgroundImage = Properties.Resources._1;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL1;
                        break;
                    case "2":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.BackgroundImage = Properties.Resources._2;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL2;
                        break;
                    case "3":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.BackgroundImage = Properties.Resources._3;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL3;
                        break;
                    case "4":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.BackgroundImage = Properties.Resources._4;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL4;
                        break;
                    case "5":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.skillsComboBox.Items.Add("Klątwa pecha");
                        this.BackgroundImage = Properties.Resources._5;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL5;
                        break;
                    case "6":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.skillsComboBox.Items.Add("Klątwa pecha");
                        this.BackgroundImage = Properties.Resources._6;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL6;
                        break;
                    case "7":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.skillsComboBox.Items.Add("Klątwa pecha");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.BackgroundImage = Properties.Resources._7;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL7;
                        break;
                    case "8":
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.skillsComboBox.Items.Add("Klątwa pecha");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.skillsComboBox.Items.Add("Kula ognia");
                        this.BackgroundImage = Properties.Resources._8;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL8;
                        break;
                    default:
                        this.skillsComboBox.Items.Add("Pocisk mocy");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Klątwa rdzy");
                        this.skillsComboBox.Items.Add("Fala ognia");
                        this.skillsComboBox.Items.Add("Klątwa pecha");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.skillsComboBox.Items.Add("Kula ognia");
                        this.BackgroundImage = Properties.Resources._9;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL9;
                        break;
                }
            }
            else
            {
                this.powerLabel.Text = "Siła:";
                switch (lvl)
                {
                    case "":
                        bindingNavigatorAddNewItem.Enabled = true;
                        useButton.Enabled = false;
                        this.BackgroundImage = Properties.Resources._1;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL1;
                        break;
                    case "1":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.BackgroundImage = Properties.Resources._1;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL1;
                        break;
                    case "2":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.BackgroundImage = Properties.Resources._2;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL2;
                        break;
                    case "3":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.BackgroundImage = Properties.Resources._3;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL3;
                        break;
                    case "4":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.BackgroundImage = Properties.Resources._4;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL4;
                        break;
                    case "5":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.skillsComboBox.Items.Add("Okrzyk bojowy");
                        this.BackgroundImage = Properties.Resources._5;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL5;
                        break;
                    case "6":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.skillsComboBox.Items.Add("Okrzyk bojowy"); ;
                        this.BackgroundImage = Properties.Resources._6;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL6;
                        break;
                    case "7":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.skillsComboBox.Items.Add("Okrzyk bojowy");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.BackgroundImage = Properties.Resources._7;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL7;
                        break;
                    case "8":
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.skillsComboBox.Items.Add("Okrzyk bojowy");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.skillsComboBox.Items.Add("Cięcie wichru");
                        this.BackgroundImage = Properties.Resources._8;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL8;
                        break;
                    default:
                        this.skillsComboBox.Items.Add("Zwykły cios");
                        this.skillsComboBox.Items.Add("Leczenie");
                        this.skillsComboBox.Items.Add("Strzaskanie pancerza");
                        this.skillsComboBox.Items.Add("Tornado ostrzy");
                        this.skillsComboBox.Items.Add("Okrzyk bojowy");
                        this.skillsComboBox.Items.Add("Większe leczenie");
                        this.skillsComboBox.Items.Add("Cięcie wichru");
                        this.BackgroundImage = Properties.Resources._9;
                        mapForm.mapPictureBox.Image = Properties.Resources.mapaLvL9;
                        break;
                }
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";
            this.skillsComboBox.Text = "";
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";
            this.skillsComboBox.Text = "";
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";
            this.skillsComboBox.Text = "";
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            this.logTextBox.Text = "";
            this.skillsComboBox.Text = "";
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
        }

        /// <summary>
        /// Po kliknięciu w przycisk "AddNewItem" metoda ustawia domyślne wartości oraz odblokowuje 
        /// pola wyboru imienia i klasy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nameTextBox.Enabled = true;
            classComboBox.Enabled = true;
            questButton.Enabled = true;
            logTextBox.Text = "1.Kliknij przycisk 'Dodaj nowy' (żółty plusik), aby stworzyć nowy zapis."
                + Environment.NewLine + "2.Podaj swoje imię."
                + Environment.NewLine + "3.Wybierz klasę."
                + Environment.NewLine + "4.Naciśnij przycisk 'Szukaj przygód!', aby zacząć grę.";
            skillsComboBox.Text = "";
            nameTextBox.Text = "Bezimienny";
            classComboBox.Text = "Wojownik";
            dmgValueLabel.Text = "20";
            lifeValueLabel.Text = "150";
            luckValueLabel.Text = "15";
            expValueLabel.Text = "0";
            lvlValueLabel.Text = "1";
            wDmgValueLabel.Text = "0";
            helmetValueLabel.Text = "0";
            breastplateValueLabel.Text = "10";
            glovesValueLabel.Text = "0";
            bootsValueLabel.Text = "5";
        }

        /// <summary>
        /// Jeżeli usuniemy ostatni rekord, to metoda blokuje pola imienia, klasy i mapy.
        /// Wymusza pośrednio użycie przycisku "AddNewItem", który ustawia domyślne wartości 
        /// wszystkich pól i pozwala zacząć grę.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (bindingNavigatorPositionItem.Text == "0")
            {
                nameTextBox.Enabled = false;
                classComboBox.Enabled = false;
                mapButton.Enabled = false;
                useButton.Enabled = false;
                questButton.Enabled = false;
                skillsComboBox.Items.Clear();
            }
            this.logTextBox.Text = "";
            this.skillsComboBox.Text = "";
            this.nameTextBox.Enabled = false;
            this.classComboBox.Enabled = false;
            //gameDBDataSet.Character.AcceptChanges();
        }

        private void characterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(classComboBox.Text.Trim()) || String.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                MessageBox.Show("Pola imię oraz klasa nie mogą być puste.", "Uwaga!");
            }
            else if (duringTheQuestOrFight || firstSideQuest || secondSideQuest || thirdSideQuest || fourthSideQuest || fifthSideQuest || afterFourthQuest || afterFifthQuest || afterSixthQuest || afterSeventhQuest || afterEightQuest || afterNinthQuest)
            {
                MessageBox.Show("Nie można zapisać podczas trwania misji lub walki. Dokończ obecną misję lub walkę aby móc zapisać stan gry.", "Trwa misja!");
            }
            else
            {
                this.Validate();
                this.characterBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gameDBDataSet);
                if (this.Validate())
                {
                    this.nameTextBox.Enabled = false;
                    this.classComboBox.Enabled = false;
                    MessageBox.Show("Zapisano postęp.", "Uwaga!");
                }
            }
        }

        /// <summary>
        /// Metoda zabezpiecza przed dopisaniem tekstu przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bindingNavigatorPositionItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Metoda zabezpiecza przed dopisaniem tekstu przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skillsComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Metoda zabezpiecza przed dopisaniem tekstu przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void targetComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Metoda zabezpiecza przed dopisaniem tekstu przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void logTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        /// <summary>
        /// Metoda zabezpiecza przed dopisaniem tekstu przez użytkownika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            e.Handled = true;
            tooltip.Show("Wybierz dostępną klasę.", classComboBox, 0, -20, 2000);
        }

        /// <summary>
        /// Metoda sprawdza dozwolone znaki oraz prawidłową długość imienia.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            ToolTip tooltip = new ToolTip();
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == '\b')
            {
                if (nameTextBox.Text.Length <= 13 || e.KeyChar == (char)8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    tooltip.ToolTipTitle = "Zbyt długie imię.";
                    tooltip.Show("Imię może mieć maksymalnie 13 znaków.", nameTextBox, 0, -20, 2000);
                }
            }
            else
            {
                tooltip.ToolTipTitle = "Niedozwolony znak.";
                tooltip.Show("Imię musi zawierać tylko litery.", nameTextBox, 0, -20, 2000);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Metoda ustawia domyślne wartości pól zależnie od wybranej klasy postaci.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (classComboBox.SelectedIndex == 0)
            {
                powerLabel.Text = "Siła:";
                dmgValueLabel.Text = "20";
                lifeValueLabel.Text = "150";
                luckValueLabel.Text = "15";
                expValueLabel.Text = "0";
                lvlValueLabel.Text = "1";
                wDmgValueLabel.Text = "0";
                helmetValueLabel.Text = "0";
                breastplateValueLabel.Text = "10";
                glovesValueLabel.Text = "0";
                bootsValueLabel.Text = "5";
            }
            else
            {
                powerLabel.Text = "Moc:";
                dmgValueLabel.Text = "40";
                lifeValueLabel.Text = "100";
                luckValueLabel.Text = "10";
                expValueLabel.Text = "0";
                lvlValueLabel.Text = "1";
                wDmgValueLabel.Text = "0";
                helmetValueLabel.Text = "0";
                breastplateValueLabel.Text = "5";
                glovesValueLabel.Text = "0";
                bootsValueLabel.Text = "5";
            }
        }

        /// <summary>
        /// Wyświetla opis danej umiejętności w oknie logTextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpButton_Click(object sender, EventArgs e)
        {
            string skillSelected = this.skillsComboBox.Text.Trim();

            switch (skillSelected)
            {
                case "Zwykły cios":
                case "Pocisk mocy":
                    addTextToLogTextBox(Environment.NewLine + skillSelected + " zadaje od 30 do 50 obrażeń własnych przeciwnikowi. Może trafić krytycznie.");
                    break;
                case "Leczenie":
                    addTextToLogTextBox(Environment.NewLine + "Leczysz swoje rany do 100 punktów życia.");
                    break;
                case "Większe leczenie":
                    addTextToLogTextBox(Environment.NewLine + "Leczysz swoje rany do 200 punktów życia.");
                    break;
                case "Strzaskanie pancerza":
                    addTextToLogTextBox(Environment.NewLine + "Strzaskanie pancerza niszczy połowę pancerza wroga.");
                    break;
                case "Klątwa rdzy":
                    addTextToLogTextBox(Environment.NewLine + "Klątwa rdzy rzucona na wrogów sprawia, że ich pancerz natychmiast rdzewieje i chroni o połowę słabiej.");
                    break;
                case "Klątwa pecha":
                    addTextToLogTextBox(Environment.NewLine + "Klątwa pecha przeklina wrogów zmniejszając ich szanse na blok lub trafienie krytyczne o połowę.");
                    break;
                case "Okrzyk bojowy":
                    addTextToLogTextBox(Environment.NewLine + "Okrzyk bojowy wywołuje trwogę u wrogów zmniejszając ich szanse na blok lub trafienie krytyczne o połowę.");
                    break;
                case "Tornado ostrzy":
                case "Fala ognia":
                    addTextToLogTextBox(Environment.NewLine + skillSelected + " zadaje od 30 do 50 obrażeń własnych wszystkim napotkanym przeciwnikom. Nie może trafić krytycznie.");
                    break;
                case "Cięcie wichru":
                case "Kula ognia":
                    addTextToLogTextBox(Environment.NewLine + skillSelected + " zadaje od 50 do 100 obrażeń własnych przeciwnikowi. Może trafić krytycznie.");
                    break;
                default:
                    addTextToLogTextBox(Environment.NewLine + "Wybierz jakąś umięjętność z pola obok by dowiedzieć się o niej więcej.");
                    break;
            }
        }

        /// <summary>
        /// Wyświetlenie formularza mapy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mapButton_Click(object sender, EventArgs e)
        {
            mapForm.Show();
        }

        /// <summary>
        /// Wyświetlenie okna z podstawowymi zasadami gry.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tutorialButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Wojownik z każdym poziomem zyskuje więcej życia niż mag. \n- Mag co poziom zyskuje więcej mocy niż wojownik siły. \n- Wraz z nowym poziomem wojownik zyskuje +1 do szczęścia, a mag +3. \n- Im wyższe Twoje szczęście, tym większa szansa na cios krytyczny oraz na znajdowanie nowych przedmiotów. \n- Pancerz za każdym razem pochłania ilość obrażeń równą jego wartości. \n- Blok, jeżeli zachodzi, zatrzymuje ilość obrażeń równą jego wartości. \n- Grę możesz zapisywać tylko będąc poza misją i poza walką. \n- Używasz swoich umiejętności jako pierwszy. Następnie jest kolej na ruch wszystkich napotkanych przeciwników. \n- Całkowite obrażenia jakie zadasz przeciwnikowi są równe sumie obrażeń własnych umiejętności, obrażeń broni i siły/mocy. \n- Im wyższe szczęście stwora, tym większa jego szansa na zadanie ciosu krytycznego lub wykonanie bloku. \n- Z rzadszych i silniejszych przeciwników wypadają lepsze przedmioty. \n- Przeciwnik jest tym silnijszejszy, im wyższy ma lvl. \n- Rzadkość przeciwnika ma wpływ na ilość doświadczenia, które jest warty, ale nie na jego siłę. \n- Po każdej walce odpoczywasz przy ognisku, więc Twoje życie odnawia się do wartości sprzed walki.", "Wskazówki");
        }

        /// <summary>
        /// Wykonanie jednej tury walki. Postać zadaje obrażenia potworom, a następnie robią to potwory. 
        /// Jeżeli postać zginęła w poprzedniej turze, to zostaje wczytany ostatni zapis. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.lifeValueLabel.Text) || Convert.ToInt32(this.lifeValueLabel.Text) <= 0)
            {
                loadCharacter();
            }
            else
            {
                addTextToLogTextBox("");
                characterUseAbility(this.skillsComboBox.Text.Trim());
                addTextToLogTextBox("");
                foreach (var monster in currentlyFigthingMonsters)
                {
                    characterTakeDamage(monster.Name, monster.DoDamage());
                }
            }
        }

        /// <summary>
        /// Wywołuje metody odpowiedzialne za misje w grze.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void questButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text.Trim()))
            {
                MessageBox.Show("Pole imię nie może być puste!", "Uwaga!");
            }
            else
            {
                //Podczas wykonywania misji menu zapisów jest niedostępne.
                this.bindingNavigatorMoveFirstItem.Enabled = false;
                this.bindingNavigatorMoveNextItem.Enabled = false;
                this.bindingNavigatorMovePreviousItem.Enabled = false;
                this.bindingNavigatorMoveLastItem.Enabled = false;
                this.bindingNavigatorDeleteItem.Enabled = false;
                this.bindingNavigatorAddNewItem.Enabled = false;
                this.skillsComboBox.Enabled = true;
                this.mapButton.Enabled = true;
                this.helpButton.Enabled = true;
                this.maxCharacterLife = this.lifeValueLabel.Text;
                int characterExp = Convert.ToInt32(expValueLabel.Text);

                if (characterExp == 0)
                {
                    firstQuest();
                }
                else if (characterExp >= 100 && characterExp < 190)
                {
                    secondQuest();
                }
                else if (characterExp >= 335 && characterExp < 485)
                {
                    thirdQuest();
                }
                else if (characterExp >= 700 && characterExp < 920)
                {
                    fourthQuest();
                }
                else if (characterExp >= 1265 && characterExp < 1615)
                {
                    fifthQuest();
                }
                else if (characterExp >= 1995 && characterExp < 2445)
                {
                    sixthQuest();
                }
                else if (characterExp >= 2890 && characterExp < 3390)
                {
                    seventhQuest();
                }
                else if (characterExp >= 3900 && characterExp < 4500)
                {
                    eighthQuest();
                }
                else if (characterExp >= 5075 && characterExp < 5775)
                {
                    ninthQuest();
                }
                else
                {
                    simpleQuest();
                }
                //Ustawienie aktualnego tła, mapy i umiejętności postaci.
                changeThingsToActualSave();
            }
        }
    }
}
