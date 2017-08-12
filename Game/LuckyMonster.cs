using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class LuckyMonster:Monster
    {
        private double criticalDamageMultiplier;

        public double CriticalDamageMultiplier
        {
            get { return criticalDamageMultiplier; }
        }

        private int luck;

        public int Luck
        {
            get { return luck; }
            set { luck = value; }
        }

        public LuckyMonster(string rarity, string name, int life, int power, int lvl, int luck, double criticalDamageMultiplier)
            : base(rarity, name, life, power, lvl)
        {
            this.luck = luck;
            this.criticalDamageMultiplier = criticalDamageMultiplier;
        }

        /// <summary>
        /// Opisuje spotkanego stwora.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public override string Description(bool longDescription)
        {
            return base.Description(longDescription) + " Potrafi uderzyć krytycznie. Szansa " + this.Luck + ". Mnożnik " + this.CriticalDamageMultiplier + ".";
        }

        public override int DoDamage()
        {
            if (this.luck > GameForm._GameForm.random.Next(0, 101))
            {
                GameForm._GameForm.addTextToLogTextBox("Krytyczny cios!");
                return Convert.ToInt32(Math.Floor(base.DoDamage() * this.criticalDamageMultiplier));
            }
            else
            {
                return base.DoDamage();
            }
        }

        /// <summary>
        /// Metoda będzie obniżać szczęście do momentu przekroczenia 5 punktów.
        /// </summary>
        /// <param name="percent"></param>
        /// <returns></returns>
        public string LowerLuck(double percent)
        {
            int oldLuck = this.luck;
            if (this.luck <= 5)
            {
                return "Nie można już bardziej obniżyć szczęścia tego stwora!";
            }
            else
            {
                this.luck -= Convert.ToInt32(Math.Floor(percent * this.luck));
                return "Stwora od teraz prześladuje pech! Szczęście spada z " + oldLuck + " do " + this.luck + ".";
            }
        }
    }
}
