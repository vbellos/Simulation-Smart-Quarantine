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
    public partial class OrderViewForm : Form
    {
        public OrderViewForm()
        {
            InitializeComponent();
        }
        public OrderViewForm(Order order) : this()
        {
            foodPanel.SetTitle("Order : "+order.Time.ToString());
            foodPanel.init(order.Orderlist);
            foodPanel.LockControlls();
            total.Text = order.Ordertotal.ToString();
            address.Text = order.Address;
        }


        private void OrderViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
