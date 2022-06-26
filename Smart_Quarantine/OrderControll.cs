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
    public partial class OrderControll : UserControl
    {

        Order order;

        public OrderControll()
        {
            InitializeComponent();
        }

        public OrderControll(Order o) : this()
        {
            order = o;
            DateLabel.Text = order.Time.ToString();
            totalLabel.Text = order.Ordertotal.ToString();
            richTextBox1.Text = order.OrderString;
            payLabel.Text = order.Payedby;
            
        }

        private void OrderControll_Load(object sender, EventArgs e)
        {

        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            OrderViewForm ovf = new OrderViewForm(order);
            ovf.ShowDialog();
        }
    }
}
