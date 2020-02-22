using System;
using System.Collections.Generic;
using System.Text;

namespace CourseApp
{
    public class Store
    {
        private string marka;
        private int voltage;
        private int warranty;

        public void BuyNew(string marka1, int voltage1, int warranty1)
        {
            if ((voltage > 0) && (marka != string.Empty))
            {
                marka = marka1;
                voltage = voltage1;
                warranty = warranty1;
            }
            else
            {
                throw new ArgumentOutOfRangeException("You Appliances willn't work");
            }
        }
    }
}
