using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualMethodHW
{
    class BaseWarrior
    {
        public int LivesNumber { get; set; }

        public BaseWarrior(int livesNumber)
        {
            LivesNumber = livesNumber;
        }
        public virtual void GetDamage(int damage)
        {
            LivesNumber -= damage;
            Console.WriteLine("Итого жизни: " + LivesNumber);
        }

    }
}
