using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Cruiser : Ship
    {
        public Cruiser()
        : base("Unnamed Cruiser")
        {
        }

        public Cruiser(string name)
        : base(name, 1)
        {
        }

        public Cruiser(string name, double length)
        : base(name, length, 1)
        {
        }

        public Cruiser(string name, double length, double displacement)
        : base(name, length, displacement)
        {
            Name = name;
            Length = length;
            Displacement = displacement;
        }

        public override double Length
        {
            get
            {
                return base.Length;
            }

            set
            {
                if (value >= 0 && value <= 300)
                {
                    base.Length = value;
                }
                else
                {
                    throw new System.Exception("Wrong lenght");
                }
            }
        }

        public override double Displacement
        {
            get
            {
                return base.Displacement;
            }

            set
            {
                if (value >= 0 && value <= 40000)
                {
                    base.Displacement = value;
                }
                else
                {
                    throw new System.Exception("Wrong displacement");
                }
            }
        }

        public override void SayShip()
        {
            Console.WriteLine($"Крейсер: {Name}, Длина: {Length} м., Водоизмещение: {Displacement} т.");
        }
    }
}