using System;
using TestProjects.DecoratorTest;

namespace TestProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            // take normal reports
            Console.WriteLine(myCar.ReportArmor());
            Console.WriteLine(myCar.ReportHealth());
        }
    }
}
