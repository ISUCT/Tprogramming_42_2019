using System;

namespace CourseApp
{
    public abstract class Sudno
    {
        private double len ;
        private double displacement ;

        public Sudno() {}

        public Sudno(string n) { Name = n; }

        public Sudno(string name, double len, double displacement, bool isGoing)
        {
            Name = name; 
            Len = len; 
            Displacement = displacement; 
            IsGoing = isGoing;
        }
        public Sudno(string name, double len, double displacement) { Name = name; Len = len; Displacement = displacement; IsGoing = false;}

        public virtual double Len
        {
            get
            {
                return this.len;
            }

            set
            {
                if (value > 0)
                {
                    this.len = value;
                }
                else
                {
                    throw new LenException("Length should be > 0");
                }
            }
        }
        public virtual double Displacement
        {
            get
            {
                return this.displacement;
            }

            set
            {
                if (value > 0)
                {
                    this.displacement = value;
                }
                else
                {
                    throw new DisplacementException("Displacement should be > 0");
                }
            }
        }
        public string Name { get; set; }
        public bool IsGoing { get; set; }
        public void SetDisplacement() {
            Console.WriteLine("Введите водоизмещение коробля ");
            Displacement = Console.Read();
        }

        public void SetLen() {
            Console.WriteLine("Введите Длину коробля ");
            Len = Console.Read();
        }
        
        public void GoTo() {
             Console.WriteLine("Press 1 if your Sudno want put out to sea or else if not");
             int a = Console.Read();
             if (a == 1) IsGoing = true;
             else IsGoing = false;
        }

        public override string ToString()
        {
            return $"Имя: {Name}  Длина: {Len} Водоизмещение: {Displacement} В пути: {(IsGoing ? "да" : "нет")}";
        }
        public abstract string Riffs();
    }
}