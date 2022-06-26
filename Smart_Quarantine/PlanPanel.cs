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
    public partial class PlanPanel : UserControl
    {
        List<Plan> plans = new List<Plan>();

        public List<Plan> Plans { get => plans; set => plans = value; }

        public event EventHandler PlanListChanged;


        public PlanPanel()
        {
            InitializeComponent();
            panel.BackColor = Color.Transparent;
        }

        private void PlanPanel_Load(object sender, EventArgs e)
        {

        }

        void rmplan(object sender, System.Windows.Forms.ControlEventArgs e)
        {
        
            panel.Controls.Remove(e.Control);
            Plans = new List<Plan>();
            foreach(PlanControll pc in panel.Controls)
            {
                Plans.Add(pc.Plan);
            }
            PlanListChanged(sender, new EventArgs());

        }

        public void init(List<Plan> p)
        {
            Plans = p;
            this.panel.Controls.Clear();
            if (Plans.Count > 0)
            {
                int x = 0;
                int y = 0;

                foreach (Plan plan in Plans)
                {
                    var control = new PlanControll(plan);
                    control.Location = new Point(x, y);
                    control.Size = new Size(this.Size.Width - 20, control.Height);
                    control.PlanRemove += new ControlEventHandler(rmplan);
                    this.panel.Controls.Add(control);
                    y += control.Height;
                }
            }
        }
    }
}
