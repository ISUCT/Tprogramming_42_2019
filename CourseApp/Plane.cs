using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Plane
    {
        private int speed;
        private int high;

        public Plane()
        : this(1000)
        {
        }

        public Plane(int speed)
        : this(speed, 1000)
        {
        }

        public Plane(int speed, int high)
        : this(speed, high, " ")
        {
        }

        public Plane(int speed, int high, string model)
        {
            Speed = speed;
            High = high;
            Model = model;
        }

        public int Speed
        {
            get
            {
                return this.speed;
            }

            set
            {
                if (value >= 1 && value < 2570)
                {
                    this.speed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Speed", "Speed should be >= 1 and =< than 2570");
                }
            }
        }

        public int High
        {
            get
            {
                return this.high;
            }

            set
            {
                if (value >= 1 && value < 12000)
                {
                    this.high = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "High should be >= 1 and < than 12000");
                }
            }
        }

        public string Model { get; set; }

        public override string ToString()
        {
            return $"Взлетел, Модель:{Model}, Скорость:{Speed}, Высота:{High}";
        }

        public void TakeOff()
        {
            Console.WriteLine("Взлетел");
        }

        public void UpSpeed()
        {
            this.speed++;
        }

        public void HighDown()
        {
            this.high--;
        }
    }
}