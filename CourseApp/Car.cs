using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Car
    {
        private int speed;
        private int age;

        public Car()
        : this("Неизвестно")
        {
        }

        public Car(string brand)
        : this(brand, 0)
        {
        }

        public Car(string brand, int age)
        : this(brand, age, 0)
        {
        }

        public Car(string brand, int age, int speed)
        {
            Brand = brand;
            Age = age;
            Speed = speed;
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
                if (value > 0 && value < 20)
                {
                    this.age = value;
                }
                else
                {
                    Console.WriteLine("Age should be > 0 and < than 20");
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
                if (value > 0)
                {
                    this.speed = value;
                }
                else
                {
                    Console.WriteLine("Speed should be > 0");
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Бренд:{Brand}, Возраст:{Age}, Скорость:{Speed}");
        }

        public void Sound()
        {
            Console.WriteLine("Врум!");
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
