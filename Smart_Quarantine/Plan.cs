using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Quarantine
{
    public class Plan
    {
        private DateTime time;
        private String type;
        private String location;
        private String transport;
        private System.Drawing.Image image;


        public DateTime Time { get => time; set => time = value; }
        public string Type { get => type; set { type = value; SetImage(value); } }
        public string Location { get => location; set => location = value; }
        public string Transport { get => transport; set => transport = value; }
        public Image Image { get => image; set => image = value; }

        void SetImage(String t) 
        {
            t = t.Trim();
            if(t == "Β1: Medical Purposes") { image = Properties.Resources.B1; }
            else if (t == "B2: Shopping") { image = Properties.Resources.B2; }
            else if (t == "B3: Public Service") { image = Properties.Resources.B3; }
            else if (t == "B4: Provide Assistanse") { image = Properties.Resources.B4; }
            else if (t == "B5: Funeral") { image = Properties.Resources.B5; }
            else if (t == "B6: Personal Excersise") { image = Properties.Resources.B6; }

        }

        public String PlanText()
        {
            string t = "Type of transportation: "+ type;
            t = t+ "\n location: "+location;
            t = t + "\n means of transport: "+ transport;
            t = t + "\n At: " + time.ToString();
            return t;
        }

    }
}
