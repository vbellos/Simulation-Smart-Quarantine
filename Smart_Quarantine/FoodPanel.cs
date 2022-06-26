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
    public partial class FoodPanel : UserControl
    {

        private List<Food> selected_foods = new List<Food>();
        public FoodPanel()
        {
            InitializeComponent();
        }


        public void init(List<Food> foods)
        {

            int x = 0;
            int y = 0;
            bool odd = true;
            foreach (Food f in foods)
            {
                var control = new foodcontroll(f);
                control.Location = new Point(x, y);
                panel.Controls.Add(control);
                if (odd) { x = control.Width; }
                else { x = 0; y += control.Height; }
                odd = !odd;
            }

        }

        public void LockControlls()
        {
            foreach (foodcontroll fc in this.panel.Controls)
            {
                fc.lock_controll();
            }
        }

        public void SetTitle(String t) { title_label.Text = t; }

        public List<Food> SelectedFoods 
        { get 
            {
                List<Food> temp_list = new List<Food>();

                foreach (foodcontroll fc in panel.Controls)
                {
                    if (fc.Food != null && fc.Food.Quantiny > 0)
                    {
                        temp_list.Add(fc.Food);
                    }
                }
                return temp_list;
            } 
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
