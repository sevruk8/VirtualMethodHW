using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodHW
{
    class HeavyArmorWarrior : BaseWarrior
    {
        public int HArmor { get; set; }

        public HeavyArmorWarrior(int livesNumber, int hArmor) :
            base(livesNumber)
        {
            HArmor = hArmor + 20;
        }
        public override void GetDamage(int damage)
        {
            LivesNumber = (LivesNumber + HArmor) - damage;
            Console.WriteLine("Итого жизни в легких доспехах: " + LivesNumber);
        }
    }
}
