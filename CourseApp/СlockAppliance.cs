using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class СlockAppliance : Appliances
    {
        private DateTime time;

        public СlockAppliance()
        : this(" ")
        {
        }

        public СlockAppliance(string nazvanie)
        : this(nazvanie, "untitled")
        {
        }

        public СlockAppliance(string nazvanie, string marka)
        : this(nazvanie, marka, 220)
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage)
        : this(nazvanie, marka, voltage, 1)
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage, int warranty)
        : this(nazvanie, marka, voltage, warranty, new DateTime(2000, 11, 23))
        {
        }

        public СlockAppliance(string nazvanie, string marka, int voltage, int warranty, DateTime time1)
        : base(nazvanie, marka, voltage, warranty)
        {
            this.Time2 = time1;
        }

        public DateTime Time2
        {
            get
            {
                return this.time;
            }

            set
            {
                if ((value >= new DateTime(2000, 11, 13)) && (value < new DateTime(2022, 12, 28)))
                {
                    this.time = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Unacceptable time");
                }
            }
        }

        public override string Broke()
        {
            return "Your Appliance is broken";
        }
    }
}