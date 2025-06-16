using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Magician : Fighter
    {
        private int _mana;
        private int _pressetFireBall;
        private int _damageFireBall;
        private int _baseCountMana;
        private int _fineDamage;
        private int _damage;

        public Magician(string name) : base(name, "Маг")
        {
            _baseCountMana = 100;
            _mana = _baseCountMana;
            _pressetFireBall = 25;
            _damageFireBall = ArenaSetting.BaseDamage * 5;
            _fineDamage = 3;
            _damageFireBall = ArenaSetting.BaseDamage - _fineDamage;
            _damage = ArenaSetting.BaseDamage - _fineDamage;
        }

        public override void DealDamage(Fighter fighter)
        {
            if (_mana > 0)
            {
                Console.WriteLine($"{Title} {Name} сотворил огненный шар. У него осталось {_mana} манны");
                fighter.TakeDamage(ArenaSetting.GetRandomNumber(_damageFireBall));
            }
            else
            {
                if(ArenaSetting.IsEvent(10))
                {
                    Console.WriteLine($"{Name} удар посохом");
                    fighter.TakeDamage(ArenaSetting.GetRandomNumber(_damage));
                }
                else 
                {
                    Console.WriteLine($"{Name} промахнулся посохом");
                }
            }
        }

        public override void Restore()
        {
            base.Restore();
            _mana = _baseCountMana;
        }
    }
}
