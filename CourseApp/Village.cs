using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Village : Settlement
    {
        public Village()
        : base("Unnamed")
        {
        }

        public Village(string name)
        : base(name, 1)
        {
        }

        public Village(string name, int population)
        : this(name, population, 0)
        {
        }

        public Village(string name, int population, int square)
         : base(name, population, square)
        {
            Name = name;
            Population = population;
            Square = square;
        }

        public override int Population
        {
            set
            {
                if (value >= 0 && value < 500000)
                {
                    base.Population = value;
                }
                else
                {
                    throw new System.Exception("Wrong population");
                }
            }
        }

        public override int Square
        {
            get
            {
                return base.Square;
            }

            set
            {
                if (value >= 0 && value <= 500000)
                {
                    base.Square = value;
                }
                else
                {
                    throw new System.Exception("Wrong square");
                }
            }
        }

        public override string ToString()
        {
            return $"Name of Village:{Name},Population of Village:{Population}, Square of Village:{Square}";
        }
    }
}
