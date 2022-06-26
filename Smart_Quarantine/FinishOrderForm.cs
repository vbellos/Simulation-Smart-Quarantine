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
    public partial class FinishOrderForm : Form
    {
        Order order;
        bool finish = false;
        
        public FinishOrderForm(Order o)
        {
            InitializeComponent();
            Order = o;
            richTextBox.Text = order.OrderString;
            total.Text = order.Ordertotal.ToString();

        }

        public Order Order { get => order; set => order = value; }
        public bool Finish { get => finish; set => finish = value; }

        private void FinishOrderForm_Load(object sender, EventArgs e)
        {
            tabcontrol.ItemSize = new Size(0, 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (address.Text != "") 
            {
                order.Address = address.Text;

                if (cash.Checked) { order.Payedby = "Cash"; tabcontrol.SelectedTab = tabFinish; }
                else { tabcontrol.SelectedTab = tabCard; }
            }
            else { MessageBox.Show("Please enter your street address","error"); }
        }

        private void tabcontrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol.SelectedTab == tabFinish) { finish = true; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" )
                {
                    order.Payedby = "Card";
                    tabcontrol.SelectedTab = tabFinish;
                }
                else { MessageBox.Show("Please enter your card details", "error"); }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
