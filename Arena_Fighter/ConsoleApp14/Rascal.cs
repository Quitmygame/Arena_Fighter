using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Rascal : Fighter
    {
        private int _probability;
        private int _countAttack;

        public Rascal(string name) : base(name, "Дуэлянт")
        {
            _probability = 25;
            _countAttack = 3;
        }

        public override void DealDamage(Fighter fighter)
        {
            if(ArenaSetting.IsEvent(_probability))
            {
                for (int i = 0; i < _countAttack; i++)
                    Attack(fighter);
            }
            else 
            {
                Attack(fighter);
            }
        }

        private void Attack(Fighter fighter)
        {
            if(ArenaSetting.IsEvent(_probability))
            {
                Console.WriteLine($"{Title} {Name} смог попасть");
                fighter.TakeDamage(Damage);
            }
            else 
            {
                Console.WriteLine($"{Title} {Name} промахнулся");
            }
        }
    }
}
