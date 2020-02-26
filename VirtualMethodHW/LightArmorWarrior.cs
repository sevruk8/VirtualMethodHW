using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodHW
{
    class LightArmorWarrior : BaseWarrior
    {
        public int LArmor { get; set; }

        public LightArmorWarrior (int livesNumber, int lArmor) :
            base(livesNumber)
        {
            LArmor = lArmor + 10;
        }
        public override void GetDamage(int damage)
        {
            LivesNumber = (LivesNumber + LArmor) - damage;
            Console.WriteLine("Итого жизни в легких доспехах: " + LivesNumber);
        }
    }
}
