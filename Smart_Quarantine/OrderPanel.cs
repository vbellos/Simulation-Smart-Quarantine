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
    public partial class OrderPanel : UserControl
    {

        public OrderPanel()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void init(List<Order> orders) 
        {
            if (orders.Count > 0)
            {
                int x = 0;
                int y = 0;

                foreach (Order order in orders)
                {
                    var control = new OrderControll(order);
                    control.Location = new Point(x, y);
                    control.Size = new Size(this.Size.Width - 30,control.Height);
                    panel.Controls.Add(control);
                    y += control.Height;
                }
            }
        }

        private void OrderPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
