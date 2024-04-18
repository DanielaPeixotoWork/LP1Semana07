using System;

namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health { get; set; } 

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move() 
        {
            Console.WriteLine("A unidade moveu " + movement + " casas.");
        }

        public abstract float Cost { get; } 
    }
}
