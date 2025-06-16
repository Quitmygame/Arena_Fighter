using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Paladin: Fighter
    {
        private int _probabilityWillChange;

        public Paladin(string name) : base(name, "Паладин")
        {
            _probabilityWillChange = 5;
        }

        public override void DealDamage(Fighter fighter)
        {
            Console.WriteLine($"{Title} {Name} ударил");
            fighter.TakeDamage(ArenaSetting.GetRandomNumber(Damage));
        }

        public override void TakeDamage(int damage)
        {
            if (ArenaSetting.IsEvent(_probabilityWillChange))
            {
                Console.WriteLine($"{Name} вылечил себя");
                Restore();
            }
            else
            {
                base.TakeDamage(damage);
            }
        }
    }
}
