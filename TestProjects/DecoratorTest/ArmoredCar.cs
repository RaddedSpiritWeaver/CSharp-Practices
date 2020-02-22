using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjects.DecoratorTest
{
    class ArmoredCar : ICar
    {

        private ICar _decoratedCar;

        public int Health { get; set; }
        public int Speed { get; set; }
        public int Armor { get; set; }

        public ArmoredCar(ICar undecoratedCar)
        {
            this._decoratedCar = undecoratedCar;
        }

        public int ReportArmor() => _decoratedCar.ReportArmor() + 20;

        public int ReportHealth() => this._decoratedCar.ReportHealth() + 100;

        public void GetDamaged(int dmg) => this._decoratedCar.GetDamaged(dmg);
    }
}
