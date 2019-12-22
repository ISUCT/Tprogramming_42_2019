using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Ship
    {
        private double length;
        private double displacement;

        public Ship()
        : this("Unnamed")
        {
        }

        public Ship(string name)
        : this(name, 1)
        {
        }

        public Ship(string name, double length)
        : this(name, length, 1)
        {
        }

        public Ship(string name, double length, double displacement)
        {
            Name = name;
            Length = length;
            Displacement = displacement;
        }

        public string Name { get; set; }

        public virtual double Length
        {
            get
            {
                return length;
            }

            set
            {
                if (value > 0)
                {
                    length = value;
                }
                else
                {
                    throw new System.Exception("Wrong lenght");
                }
            }
        }

        public virtual double Displacement
        {
            get
            {
                return displacement;
            }

            set
            {
                if (value > 0)
                {
                    displacement = value;
                }
                else
                {
                    throw new System.Exception("Wrong displacement");
                }
            }
        }

        public override string ToString()
        {
            return $"Name:{Name}, Lenght:{Length}, Displacement:{Displacement}";
        }

        public abstract void SayShip();
    }
}