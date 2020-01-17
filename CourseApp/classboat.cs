using System;

namespace CourseApp 
{
    public class Boat : Sudno
    {
        public Boat()
        : this("Untitled")
        {
        }

        public Boat(string name)
        : this(name, 0)
        {
        }

        public Boat(string name, double len)
        : this(name, 0, 0)
        {
        }

        public Boat( string name, double len, double displacement )
        : this(name, len, displacement, true)
        {
        }
        public Boat(string name, double len, double displacement, bool isGoing)
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
                if (value > 0 && value < 50)
                {
                    base.Len = value;
                }
                else
                {
                    throw new LenException("Len should be > 0 and < 50 ");
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
                if (value > 0 && value < 50)
                {
                    base.Displacement = value;
                }
                else
                {
                    throw new DisplacementException("Displacement should be > 0 and < 50 ");
                }
            }
        }
        public override string Riffs()
        {
            if (IsGoing){return "Так как у вас лодка вы не сели на мель";}
            else {return "вы не в плаваньи";}
        }
    }
}