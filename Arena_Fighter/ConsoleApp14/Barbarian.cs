using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Barbarian: Fighter
    {
        private bool _isEnraged;

        public Barbarian(string name):base(name, "Варвар")
        {
            _isEnraged = false;
        }

        public override void DealDamage(Fighter fighter)
        {
            if(_isEnraged)
            {
                Console.WriteLine($"{Title} {Name} в ярости и наносит повышенный урон");
                fighter.TakeDamage(Damage * 2);
            }
            else 
            {
                Console.WriteLine($"{Title} {Name} атакует");
                fighter.TakeDamage(Damage);
            }
        }

        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);

            if(HealthPoints < 50 && !_isEnraged)
            {
                _isEnraged = true;
                Console.WriteLine($"{Title} {Name} впадает в ярость");
            }
        }
    }
}
