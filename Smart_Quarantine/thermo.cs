using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    class thermo
    {
        private double therm;
        
        public thermo()
        {
            this.therm = 0;
        }


        public void SetTherm(double t)
        {
            this.therm = t;
        }
        public double GetTherm()
        {
            return this.therm;
        }

        public System.Drawing.Color GenerateColor() 
        {
            System.Drawing.Color color;
            double t = this.therm;

            if (t < 36) { color = System.Drawing.Color.MediumBlue; }
            else if (t < 37) { color = System.Drawing.Color.Lime; }
            else if (t < 37.5) { color = System.Drawing.Color.Yellow; }
            else if (t < 38.5) { color= System.Drawing.Color.OrangeRed; }
            else { color = System.Drawing.Color.Red; }

            return color;
        }

        public void GenerateTherm() 
        {
            var list = new List<double>();

            for (int i = 0; i < 80; i++)
            {
                if (i < 10) 
                { double t = 35 + i * 0.1; list.Add(t); }
                else if (i < 60)
                { double t = 36 + (i - 10) * 0.02; t = Math.Round(t, 1); list.Add(t); }
                else { double t = 37 + (i-50) *0.1; list.Add(t); }
            }

            Random rnd = new Random();
            int r_index = rnd.Next(0, 80);

            this.therm = list[r_index];

        }
        public String Message()
        {

            String mess;
            double t = this.therm;

            if (t < 36) { mess = " You have hypothermia ,you shal not enter!"; }
            else if (t < 37) { mess = null; }
            else if (t < 37.5) { mess = "You are a litle hotter than usual...rest for 5m and try again"; }
            else if (t < 38.5) { mess = "You have a high fever please take a covid test"; }
            else { mess = "You are literally boiling please leave town ASAP!!!"; }

            return mess;

        }
    }
}
