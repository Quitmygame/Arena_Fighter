using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Soldier : Fighter
    {
        private int _probabilityReflect;

        public Soldier(string name): base(name, "Солдат")
        {
            _probabilityReflect = 20;
        }

        public override void DealDamage(Fighter fighter)
        {
            if (ArenaSetting.IsEvent(_probabilityReflect))
            {
                Console.WriteLine($"{Title} {Name} смог попасть");
                fighter.TakeDamage(ArenaSetting.GetRandomNumber(Damage));
            }
            else
            {
                Console.WriteLine($"{Title} {Name} промахнулся");
            }
        }

        public override void TakeDamage(int damage)
        {
            if (ArenaSetting.IsEvent(_probabilityReflect))
                Console.WriteLine($"{Title} {Name} смог отразить урон");
            else
                base.TakeDamage(damage);
        }
    }
}
