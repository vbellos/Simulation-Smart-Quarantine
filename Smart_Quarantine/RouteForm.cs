using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Quarantine
{
    public partial class RouteForm : Form
    {
        Plan plan = new Plan();
        String new_Address;
        public RouteForm(Plan p)
        {
            InitializeComponent();
            plan = p;
            new_Address = RandStreetGen();
            richTextBox1.Text = "It seems that "+plan.Location+ " is a little busy at: "+plan.Time.ToString()+". However we found an alternative route: "+new_Address+ ". Do you want to go throught that new route;";
        }

        public Plan Plan { get => plan; set => plan = value; }

        private void RouteForm_Load(object sender, EventArgs e)
        {

        }

        String RandStreetGen()
        {
            String street;

            List<String> Streets = new List<String>();
            Streets.Add("The Spinney");
            Streets.Add("Lord Street");
            Streets.Add("Hazel Close");
            Streets.Add("South Road");
            Streets.Add("Curlew Close");
            Streets.Add("Thornhill Road");
            Streets.Add("Mill Hill");
            Streets.Add("Saxon Way");
            Streets.Add("Grove Lane");
            Streets.Add("Hillside");

            Random random = new Random();
            street = Streets[random.Next(10)] +" "+random.Next(100).ToString();
            return street;
            


        }

        private void yesbtn_Click(object sender, EventArgs e)
        {
            plan.Location = new_Address;
            this.Close();
        }

        private void nobtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
