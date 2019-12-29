using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public abstract class Settlement
    {
        private int population;
        private int square;

        public Settlement()
        : this("Unnamed")
        {
        }

        public Settlement(string name)
        : this(name, 1)
        {
        }

        public Settlement(string name, int population)
        : this(name, population, 0)
        {
        }

        public Settlement(string name, int population, int square)
        {
            Name = name;
            Population = population;
            Square = square;
        }

        public string Name { get; set; }

        public virtual int Population
        {
            get
            {
                return population;
            }

            set
            {
                if (value >= 0)
                {
                    population = value;
                }
                else
                {
                    throw new System.Exception("Wrong population");
                }
            }
        }

        public virtual int Square
        {
            get
            {
                return square;
            }

            set
            {
                if (value >= 0)
                {
                    square = value;
                }
                else
                {
                    throw new System.Exception("Wrong square");
                }
            }
        }

        public override string ToString()
        {
            return $"Name:{Name},Population:{Population}, Square:{Square}";
        }
    }
}
