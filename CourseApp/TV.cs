using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class TV
    {
        private int number;
        private int brightness;

        public TV()
        : this(1)
        {
        }

        public TV(int number)
        : this(number, 1)
        {
        }

        public TV(int number, int brightness)
        : this(number, brightness, " ")
        {
        }

        public TV(int number, int brightness, string marka)
        {
            Number = number;
            Brightness = brightness;
            Marka = marka;
        }

        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value >= 1 && value < 101)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Number", "Number should be >= 1 and =< than 101");
                }
            }
        }

        public int Brightness
        {
            get
            {
                return this.brightness;
            }

            set
            {
                if (value >= 1 && value < 99)
                {
                    this.brightness = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Brightness should be >= 1 and < than 99");
                }
            }
        }

        public string Marka { get; set; }

        public override string ToString()
        {
            return $"Включено,Марка:{Marka},Номер канала:{Number},Яркость:{Brightness}";
        }

        public void Turn()
        {
            Console.WriteLine("Включено");
        }

        public void NextChanel()
        {
            this.number++;
        }

        public void BrightnessDown()
        {
            this.brightness--;
        }
    }
}
