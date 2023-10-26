using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Pen
    {
        protected double price;
        protected int count;

        public Pen(int count1)
        {
            price = 18.5;
            count = count1;
        }

        public double Count_price()
        {
            double price_pen;

            price_pen = price * count;

            return price_pen;
        }
    }

    internal class felttip_pen : Pen
    {
        protected double price_felt;
        protected int count_felt;
        private int sort;

        public felttip_pen(int count1) : base(count1)
        {
            sort = 3;
            count_felt = count1;

            double formula = 1.0 / sort;

            price_felt = (price / formula) ;
            
        }

        public double Count_price_felttip()
        {
            double price_felts;

            price_felts = price_felt * count_felt;

            return price_felts;
        }
    }

}
