using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public abstract class Fighter
    {
        public Fighter(string name, string title) 
        {
            HealthPoints = ArenaSetting.BaseHealthPoints;
            Damage = ArenaSetting.BaseDamage;

            Name = name;
            Title = title;
        }

        public string Name { get; private set; }

        public string Title { get; private set; }

        public int HealthPoints { get; private set; }

        public bool IsLive => HealthPoints > 0;

        protected int Damage { get; private set; }

        public abstract void DealDamage(Fighter fighter);

        public virtual void TakeDamage(int damage)
        {
            Console.WriteLine($"{Title} {Name} принял {damage} урона. Осталось {HealthPoints} здоровья");
            HealthPoints -= damage;
        }

        public virtual void Restore()
        {
            HealthPoints = ArenaSetting.BaseHealthPoints;
        }
    }
}
