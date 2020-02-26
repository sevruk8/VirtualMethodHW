using System;
using System.Collections.Generic;

namespace VirtualMethodHW
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BaseWarrior> warriors = new List<BaseWarrior>
            {
                new BaseWarrior(20),
                new LightArmorWarrior(20, 5),
                new HeavyArmorWarrior(20, 15)
            };

            foreach (BaseWarrior b in warriors)
                b.GetDamage(10);
              
            Console.ReadKey();
        }
    }
}
