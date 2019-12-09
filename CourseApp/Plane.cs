using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Plane : Vehicle
    {
        private int passenger_place;
        private int age;

        public Plane()
        : this("Неизвестно")
        {
        }

        public Plane(string brand)
        : this(brand, 0)
        {
        }

        public Plane(string brand, int age)
        : this(brand, age, 0)
        {
        }

        public Plane(string brand, int age, int passenger_place)
        {
            Brand = brand;
            Age = age;
            Passenger_place = passenger_place;
        }

        public string Brand { get; set; }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.age = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                if (value >= 0)
                {
                    this.speed = value;
                }
                else
                {
                    throw new System.Exception();
                }
            }
        }

        public override string ToString()
        {
            return $"Бренд:{Brand}, Возраст:{Age}, Скорость:{Speed}";
        }

        public void Sound()
        {
            Console.WriteLine("ШФРУХХТТТ!");
        }

        public void Use()
        {
            this.age++;
        }

        public void Braking()
        {
            this.speed--;
        }
    }
}