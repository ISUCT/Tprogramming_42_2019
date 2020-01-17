using System;

namespace CourseApp 
{
    public class Ship : Sudno
    {
        public Ship()
        : this("Untitled")
        {
        }

        public Ship(string name)
        : this(name, 0)
        {
        }

        public Ship(string name, double len)
        : this(name, 0, 0)
        {
        }

        public Ship( string name, double len, double displacement )
        : this(name, len, displacement, true)
        {
        }
        public Ship(string name, double len, double displacement, bool isGoing)
        {
            Name = name; 
            Len = len; 
            Displacement = displacement; 
            IsGoing = isGoing;
        }
        public override double Len
        {
            get
            {
                return base.Len;
            }

            set
            {
                if (value > 10 && value < 10000)
                {
                    base.Len = value;
                }
                else
                {
                    throw new LenException("Len should be > 10 and < 10 000 ");
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
                if (value > 10 && value < 10000)
                {
                    base.Displacement = value;
                }
                else
                {
                    throw new DisplacementException("Displacement should be > 10 and < 10 000 ");
                }
            }
        }
        public override string Riffs()
        {
            if (IsGoing){return "Ваш корабль сел на мель";}
            else {return "вы не в плаваньи";}
        }
    }
}