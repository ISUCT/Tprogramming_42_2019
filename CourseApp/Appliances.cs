using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp
{
    public abstract class Appliances
    {
        private int number;
        private int voltage;

        public Appliances()
        : this(" ")
        {
        }

        public Appliances(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public Appliances(string nazvanie, string marka)
        : this(nazvanie, marka, 220)
        {
        }

        public Appliances(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 1)
        {
        }

        public Appliances(string nazvanie, string marka, int voltage, int warranty)
        {
            Nazvanie = nazvanie;
            Marka = marka;
            Voltage = voltage;
            Warranty = warranty;
        }

        public virtual int Voltage
        {
            get
            {
                return this.voltage;
            }

            set
            {
                if (value > 0 && value <= 220)
                {
                    this.voltage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0");
                }
            }
        }

        public virtual int ChanelNumber
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value > 0 && value <= 100)
                {
                    this.number = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("voltage should be > 0 and < than 380");
                }
            }
        }

        public string Nazvanie { get; set; }

        public int Warranty { get; set; }

        public string Marka { get; set; }

        public override string ToString()
        {
            string s = $"You want to by {Nazvanie}, marka: {Marka}, voltage: {Voltage},vith warranty on {Warranty}";
            return s;
        }

        public abstract string Broke();
    }
}