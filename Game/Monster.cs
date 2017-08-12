using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Monster
    {
        private string name;

        public string Name
        {
            get { return name; }

        }

        private int life;

        public int Life
        {
            get { return life; }
            set { life = value; }
        }

        private int power;

        public int Power
        {
            get { return power; }
        }

        private int lvl;

        public int Lvl
        {
            get { return lvl; }
        }

        private string rarity;

        public string Rarity
        {
            get { return rarity; }
        }

        public Monster(string rarity, string name, int life, int power, int lvl)
        {
            this.rarity = rarity;
            this.name = name;
            this.life = life;
            this.power = power;
            this.lvl = lvl;
        }

        /// <summary>
        /// Opisuje spotkanego stwora.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns></returns>
        public virtual string Description(bool longDescription)
        {
            if (longDescription)
            {
                List<string> descriptions = new List<string>()
                {
                "Na Twojej drodze staje ",
                "Z pobliskich krzaków wyskakuje ",
                "Zauważasz stwora, który zaczyna biec w Twoim kierunku! Jest to ",
                "Zachodzi Ci drogę ",
                "Nagle pojawia się przed Tobą ",
                "Widzisz, że w pobliżu przechadza się ",
                "Nie widzisz skąd wyskoczył ",
                "Zza skał wyłania się ",
                "Zaczepia Ciebie ",
                "Atakuje Ciebie ",
                "Przewraca Cię ",
                "Napada na Ciebie "
                };

                int rand = GameForm._GameForm.random.Next(0, descriptions.Count - 1);
                return descriptions[rand] + this.Rarity + " " + this.Name + " lvl " + this.Lvl + " z życiem " + this.Life + ".";
            }
            else
            {
                return this.Rarity + " " + this.Name + " lvl " + this.Lvl + " z życiem " + this.Life + ".";
            }
        }

        /// <summary>
        /// Przyjmuje obrażenia.
        /// </summary>
        /// <param name="damage"></param>
        public virtual string TakeDamage(int damage)
        {
            this.life -= damage;
            return Environment.NewLine + "Stwór " + this.Rarity + " " + this.Name + " lvl " + this.Lvl + " otrzymuje " + damage + " obrażeń." + Environment.NewLine + "Pozostało mu " + this.Life + " punktów życia.";
        }

        /// <summary>
        /// Zadaje obrażenia. 
        /// </summary>
        /// <returns></returns>
        public virtual int DoDamage()
        {
            int range = this.Lvl * 10;
            return GameForm._GameForm.random.Next(this.Power - range, this.Power + range + 1);
        }
    }
}
