using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjects.DecoratorTest
{
    public interface ICar
    {

        int Health { get; set; }

        int Speed { get; set; }

        int Armor { get; set; }

        int ReportArmor();

        int ReportHealth();

        void GetDamaged(int dmg);

    }

    public class Car : ICar
    {
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }

        public Car()
        {
            this.Health = 100;
            this.Speed = 500;
            this.Armor = 20;
        }

        public void GetDamaged(int dmg)
        {
            this.Health = this.Health - (this.Armor) * dmg / 100;
        }

        public int ReportArmor()
        { 
            return Armor;
        }

        public int ReportHealth()
        {
            return Health;
        }

        
    }
}
