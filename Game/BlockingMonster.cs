using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class BlockingMonster:LuckyMonster
    {
        private int block;

        public int Block
        {
            get { return block; }
        }

        public BlockingMonster(string rarity, string name, int life, int power, int lvl, int block, int luck, double criticalDamageMultiplier)
            : base(rarity, name, life, power, lvl, luck, criticalDamageMultiplier)
        {
            this.block = block;
        }

        /// <summary>
        ///Metoda sprawdza czy potworowi uda się zrobić blok. 
        /// </summary>
        /// <returns></returns>
        protected bool DidBlock()
        {
            if (GameForm._GameForm.random.Next(0, 101) < this.Luck)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Przyjmowanie obrażeń z uwzględnieniem bloku.
        /// </summary>
        /// <param name="damage"></param>
        /// <returns></returns>
        public override string TakeDamage(int damage)
        {
            if (DidBlock() && damage > this.Block)
            {
                this.Life -= (damage - this.Block);
                return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name + " lvl "
                    + this.Lvl + " zablokował " + this.Block + " obrażeń." + Environment.NewLine + "Zostaje zraniony za "
                    + (damage - this.Block) + " obrażeń." + Environment.NewLine + "Pozostało mu " + this.Life + " punktów życia.";
            }
            else if (DidBlock() && damage <= this.Block)
            {
                return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name + " lvl " + this.Lvl
                    + " zablokował całość " + damage + " obrażeń.";
            }
            else
            {
                this.Life -= damage;
                return Environment.NewLine + "Blok się nie powiódł." + Environment.NewLine + this.Rarity + " " + this.Name
                    + " lvl " + this.Lvl + " otrzymuje " + damage + " obrażeń." + Environment.NewLine + "Pozostało mu " + this.Life
                    + " punktów życia.";
            }
        }

        /// <summary>
        /// Opisuje spotkanego stwora.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public override string Description(bool longDescription)
        {
            return base.Description(longDescription) + " Potrafi zablokować " + this.Block + " obrażeń.";
        }
    }
}
