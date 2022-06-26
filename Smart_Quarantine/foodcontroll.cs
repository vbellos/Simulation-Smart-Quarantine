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
    public partial class foodcontroll : UserControl
    {
        
        Food food;
        public foodcontroll()
        {
            InitializeComponent();
            
        }
        public foodcontroll(Food f) :this()
        {
            food = f;
            title_label.Text = food.Name;
            pictureBox1.BackgroundImage = f.Image;
            numericUpDown1.Value = food.Quantiny;
            pr_label.Text = "Price: " + food.Price.ToString() + "€";
        }


        public Food Food { get => food; set => food = value; }

        public void lock_controll(){ numericUpDown1.Enabled = false; }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (food != null)
            {
                int quantity = Convert.ToInt32(numericUpDown1.Value);
                food.Set_quantity(quantity);
                total_label.Text = "Total: " + food.Total.ToString() + "€";
            }
        }

        private void foodcontroll_Load(object sender, EventArgs e)
        {

        }
    }
}
