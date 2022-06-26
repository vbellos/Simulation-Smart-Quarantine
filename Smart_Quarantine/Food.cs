using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    public class Food
    {
        String name;
        System.Drawing.Image image;
        double price;
        int quantiny;
        double total;
        String description;

        public Food() { quantiny = 0; }

        public Food(String N,double P,System.Drawing.Image im)
        {
            name = N;
            price = P;
            image = im;
            quantiny = 0;
        }


        public Image Image { get => image; set => image = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Quantiny { get => quantiny;  }

        public void Set_quantity(int q) { quantiny = q; total = price * q; }

        public double Total { get => total; }
        public string Description { get => description; set => description = value; }
    }
}
