using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IHasArmor
    {
        int Armor { get; set; }

        /// <summary>
        /// Obniża pancerz.
        /// </summary>
        /// <param name="percent"></param>
        string LowerArmor(double percent, string ability);
    }
}
