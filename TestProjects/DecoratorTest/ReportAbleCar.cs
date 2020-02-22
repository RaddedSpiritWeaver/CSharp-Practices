using System;
using System.Collections.Generic;
using System.Text;

namespace TestProjects.DecoratorTest
{
    interface IReportAbleCar : ICar
    {
        // this to my belief should be a method extention
        void ReportCarStatus();
    }

    class ReportAbleCar : IReportAbleCar
    {
        public int Health { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Speed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Armor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private ICar baseCar;

        public ReportAbleCar(ICar normalCar)
        {
            this.baseCar = normalCar;
            this.Health = normalCar.Health;
            this.Speed = normalCar.Speed;
            this.Armor = normalCar.Armor;
        }

        public void GetDamaged(int dmg)
        {
            baseCar.GetDamaged(dmg);
        }

        public int ReportArmor()
        {
            throw new NotImplementedException();
        }

        public void ReportCarStatus()
        {
            Console.WriteLine("property vales");
            Console.WriteLine($"health: {Health}");
            Console.WriteLine($"speed: {Speed}");
            Console.WriteLine($"armor: {Armor}");
            Console.WriteLine("probablt decorated values");
            Console.WriteLine($"health: {baseCar.ReportHealth()}");
            Console.WriteLine($"armor: {baseCar.ReportArmor()}");
        }

        public int ReportHealth()
        {
            throw new NotImplementedException();
        }
    }
}
