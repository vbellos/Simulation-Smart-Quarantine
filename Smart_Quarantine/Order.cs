using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    public class Order
    {
        DateTime time;
        List<Food> orderlist;
        double ordertotal;
        String payedby;
        String orderstring;
        String address;

        public DateTime Time { get => time; set => time = value; }
        public double Ordertotal { get => ordertotal; }
        public string Payedby { get => payedby; set => payedby = value; }
        public List<Food> Orderlist
        {
            get { return orderlist; }
            set { orderlist = value; calc_total(); }
        }

        public String OrderString
        {
            get 
            {
                orderstring = "";

                foreach (Food f in orderlist)
                {
                    orderstring += f.Quantiny.ToString() + " X " + f.Name + " : " + f.Total.ToString() + "€ \n";
                }

                return orderstring; 
            }
        }

        public string Address { get => address; set => address = value; }

        void calc_total() 
        {
            ordertotal = 0;
            foreach(Food f in orderlist)
            {
                ordertotal += f.Total;
            }
        }
    }
}
