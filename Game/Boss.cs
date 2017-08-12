using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Boss : BlockingMonster, IHasArmor
    {
        private int armor;

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }

        public Boss(string rarity, string name, int life, int power, int lvl, int block, int luck, double criticalDamageMultiplier, int armor)
            : base(rarity, name, life, power, lvl, block, luck, criticalDamageMultiplier)
        {
            this.armor = armor;
        }

        /// <summary>
        /// Opisuje spotkanego stwora.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public override string Description(bool longDescription)
        {
            return base.Description(longDescription) + " Posiada pancerz " + this.Armor + ". Boss.";
        }

        /// <summary>
        /// Obniża pancerz o procentowa wartość.
        /// </summary>
        /// <param name="percent"></param>
        /// <param name="ability"></param>
        /// <returns></returns>
        public string LowerArmor(double percent, string ability)
        {
            int oldArmor = this.Armor;

            if (this.Armor <= 0)
            {
                return "Pancerz stwora jest już całkowicie zniszczony!";
            }
            else
            {
                if (this.Armor == 1)
                {
                    this.Armor = 0;
                }
                else
                {
                    this.armor -= Convert.ToInt32(Math.Floor(percent * this.armor));
                }
                if (ability == "Klątwa rdzy")
                {
                    return "Pancerz stwora rdzewieje z zastraszającą szybkością z " + oldArmor + " do " + this.Armor + "!";
                }
                else
                {
                    return "Rostrzaskujesz pancerz stwora z " + oldArmor + " do " + this.Armor + "!";
                }

            }
        }

        /// <summary>
        /// Metoda odpowiedzialna za przyjmowanie obrażeń przez stwora. 
        /// Jeżeli stwór wykonuje blok, to o jego wartość są pomniejszone obrażenia. 
        /// Następnie obniża je pancerz stwora i dopiero obniżane jest jego życie.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        public override string TakeDamage(int damage)
        {
            //Blokuje i wartość obrażeń jest większa niż wartość bloku.
            if (DidBlock() && damage > this.Block)
            {
                //Niezablokowane obrażenia przebijają pancerz.
                if (damage - this.Block > this.Armor)
                {
                    this.Life -= (damage - this.Block - this.Armor);
                    return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name
                        + " lvl " + this.Lvl + " zablokował " + this.Block + " obrażeń." + Environment.NewLine + "Jego pancerz pochłonął "
                        + this.Armor + " obrażeń." + Environment.NewLine + "Zostaje zraniony za " + (damage - this.Block - this.Armor)
                        + " obrażeń." + Environment.NewLine + "Pozostało mu " + this.Life + " punktów życia.";
                }
                //Niezablokowane obrażenia nie przebijają pancerza.
                else
                {
                    return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name
                        + " lvl " + this.Lvl + " zablokował " + this.Block + " obrażeń." + Environment.NewLine + "Jego pancerz pochłonął resztę "
                        + (damage - this.Block) + " obrażeń." + Environment.NewLine + "Stwór nie zostaje zraniony.";
                }
            }
            //Blokuje i wartość obrażeń jest mniejsza niż wartość bloku.
            else if (DidBlock() && damage <= this.Block)
            {
                return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name + " lvl " + this.Lvl
                    + " zablokował całość " + damage + " obrażeń.";
            }
            //Nie blokuje.
            else
            {
                //Wartość obrażeń jest większa od wartości pancerza.
                if (damage > this.Armor)
                {
                    this.Life -= (damage - this.Armor);
                    return Environment.NewLine + "Blok się nie powiódł." + Environment.NewLine + "Pancerz stwora " + this.Rarity
                        + " " + this.Name + " lvl " + this.Lvl + " pochłonął " + this.Armor + " obrażeń." + Environment.NewLine
                        + "Stwór otrzymuje " + (damage - this.Armor) + " obrażeń." + Environment.NewLine + "Pozostało mu "
                        + this.Life + " punktów życia.";
                }
                //Wartość obrażeń jest mniejsza od wartości pancerza.
                else
                {
                    return Environment.NewLine + "Blok się nie powiódł." + Environment.NewLine + "Pancerz stwora " + this.Rarity + " "
                        + this.Name + " lvl " + this.Lvl + " pochłonął całość " + damage + " obrażeń.";
                }
            }
        }
    }
}
