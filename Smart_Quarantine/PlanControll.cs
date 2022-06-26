using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Quarantine
{
    public partial class PlanControll : UserControl
    {

        Plan plan;

        public PlanControll(Plan p) 
        {
            InitializeComponent();
            Plan = p;
            title.Text = plan.Type;
            date.Value = plan.Time;
            transp.Text = "Transport: " + plan.Transport;
            location.Text = "Location: " + plan.Location;
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.BackgroundImage = plan.Image;

        }

        public Plan Plan { get => plan; set => plan = value; }

        public event ControlEventHandler PlanRemove;


        private void PlanControll_Load(object sender, EventArgs e)
        {

        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            PlanRemove(sender, new ControlEventArgs(this));
        }
    }
}
