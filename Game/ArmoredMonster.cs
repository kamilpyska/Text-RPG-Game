using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class ArmoredMonster:Monster,IHasArmor
    {
        private int armor;

        public int Armor
        {
            get { return armor; }
            set { armor = value; }
        }


        public ArmoredMonster(string rarity, string name, int life, int power, int lvl, int armor)
            : base(rarity, name, life, power, lvl)
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
            return base.Description(longDescription) + " Posiada pancerz " + this.Armor + ".";
        }

        /// <summary>
        /// Przyjmowanie obrażeń przez stwora. Pancerz zmniejsza je o stałą wartość.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        public override string TakeDamage(int damage)
        {
            if (damage > this.armor)
            {
                this.Life -= (damage - this.armor);
                return Environment.NewLine + "Pancerz stwora " + this.Rarity + " " + this.Name + " lvl "
                    + this.Lvl + " pochłonął " + this.Armor + " obrażeń." + Environment.NewLine + "Stwór otrzymuje " + (damage - this.Armor)
                    + " obrażeń." + Environment.NewLine + "Pozostało mu " + this.Life + " punktów życia.";
            }
            else
            {
                return Environment.NewLine + "Pancerz stwora " + this.Rarity + " " + this.Name + " lvl "
                    + this.Lvl + " pochłonął całość " + damage + " obrażeń.";
            }
        }

        /// <summary>
        /// Obniża pancerz o procentową wartość.
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
                    return "Rostrzaskujesz pancerza stwora z " + oldArmor + " do " + this.Armor + "!";
                }
            }
        }
    }
}
