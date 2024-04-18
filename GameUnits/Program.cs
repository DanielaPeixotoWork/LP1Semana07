using System;

namespace GameUnits
{
    public class Program
    {
        static void Main()
        {
            Unit[] units = new Unit[]
            {
                new MilitaryUnit(3, 10, 2),
                new MilitaryUnit(4, 5, 3),
                new SettlerUnit(),
            };

            (units[0] as MilitaryUnit).Attack(units[1]);
            (units[0] as MilitaryUnit).Attack(units[2]);

            foreach (Unit u in units)
            {
                Console.WriteLine(u);
            }

            MilitaryUnit soldier = new MilitaryUnit(2, 10, 5);
            SettlerUnit settler = new SettlerUnit();

            soldier.Move();
            Console.WriteLine("Saúde de militar: " + soldier.Health);
            Console.WriteLine("Custo de militar: " + soldier.Cost);

            settler.Move(); // Movendo a unidade colonizadora
            Console.WriteLine("Saúde da colonizadora: " + settler.Health);
            Console.WriteLine("Custo da colonizadora: " + settler.Cost);
        }
    }
}
