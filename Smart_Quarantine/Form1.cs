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
    public partial class Form1 : Form
    {
        thermo therm = new thermo();
        smarthome smarthome = new smarthome();
        List<Plan> planList = new List<Plan>();
        TabPage prev;
        List<Food> foodlist = new List<Food>();
        List<Order> orders = new List<Order>();
        PictureBox smartphoneBtn = new PictureBox();
        PictureBox efoodbtn = new PictureBox();
        PictureBox sosbtn = new PictureBox();
        PictureBox helpbtn = new PictureBox();
        FinishOrderForm finishOrder;
        PlanPanel planPanel = new PlanPanel();
        RouteForm routeForm;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabcontrol.ItemSize = new Size(0, 1);
            tabcontrol.SelectedTab = outside;
            label1.Text = "";
            init_lights();
            //init_panel();
            addSmartphone();
            addEfoodBtn();
            addSOSBtn();
            addPlanPanel();
            addHelpBtn();
        }

        void addPlanPanel()
        {
            planPanel.Location = new Point(efoodbtn.Width, 0);
            planPanel.PlanListChanged += new EventHandler(plchanged);
            planPanel.Size = new Size(330, 474);
            planPanel.Location = new Point(500, 6);
            PlanTab.Controls.Add(planPanel);
            planPanel.BackColor = Color.Transparent;
        }
        
        void plchanged(object sender, EventArgs e)
        {
            planList = planPanel.Plans;
            planPanel.init(planList);
        }

        void addSmartphone()
        {

            smartphoneBtn.Location = new Point(10, 10);
            smartphoneBtn.Click += new EventHandler(SmBtn_Clicked);
            smartphoneBtn.Size = new Size(85, 130);

            smartphoneBtn.BackColor = Color.Transparent;
            smartphoneBtn.BackgroundImageLayout = ImageLayout.Stretch;
            smartphoneBtn.BackgroundImage = Properties.Resources.smartphone;
            this.Controls.Add(smartphoneBtn);
            smartphoneBtn.BringToFront();
        }

        void addEfoodBtn()
        {
            efoodbtn.Location = new Point(10, 10 + smartphoneBtn.Height +10);
            efoodbtn.Click += new EventHandler(EfBtn_Clicked);
            efoodbtn.Size = new Size(85, 60);

            efoodbtn.BackColor = Color.Transparent;
            efoodbtn.BackgroundImageLayout = ImageLayout.Stretch;
            efoodbtn.BackgroundImage = Properties.Resources.efood;
            this.Controls.Add(efoodbtn);
            efoodbtn.BringToFront();

        }

        void addSOSBtn()
        {
            sosbtn.Location = new Point(10, 10 + smartphoneBtn.Height + efoodbtn.Height +20);
            sosbtn.Click += new EventHandler(SOSBtn_Clicked);
            sosbtn.Size = new Size(85, 85);

            sosbtn.BackColor = Color.Transparent;
            sosbtn.BackgroundImageLayout = ImageLayout.Stretch;
            sosbtn.BackgroundImage = Properties.Resources.sos;
            this.Controls.Add(sosbtn);
            sosbtn.BringToFront();

        }

        void addHelpBtn()
        {
            helpbtn.Location = new Point(10, 10 + smartphoneBtn.Height + efoodbtn.Height +sosbtn.Height+ 20);
            helpbtn.Click += new EventHandler(HelpBtn_Clicked);
            helpbtn.Size = new Size(85, 85);

            helpbtn.BackColor = Color.Transparent;
            helpbtn.BackgroundImageLayout = ImageLayout.Stretch;
            helpbtn.BackgroundImage = Properties.Resources.help;
            this.Controls.Add(helpbtn);
            helpbtn.BringToFront();

        }

        private void HelpBtn_Clicked(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.Show();
        }

        private void SOSBtn_Clicked(object sender, EventArgs e)
        {
            ContactForm cf = new ContactForm();
            cf.Show();
        }

        private void EfBtn_Clicked(object sender, EventArgs e)
        {
            if(tabcontrol.SelectedTab != PlanTab) { prev = tabcontrol.SelectedTab; }
            efoodbtn.SendToBack();
            smartphoneBtn.SendToBack();
            sosbtn.SendToBack();
            helpbtn.SendToBack();
            tabcontrol.SelectedTab = efoodtab;
        }

        private void SmBtn_Clicked(object sender, EventArgs e) 
        {

            if (tabcontrol.SelectedTab == PlanTab) { smartphoneBtn.BackgroundImage = Properties.Resources.smartphone; tabcontrol.SelectedTab = prev; }
            else { smartphoneBtn.BackgroundImage  = Properties.Resources.smartphone_r; prev = tabcontrol.SelectedTab; tabcontrol.SelectedTab = PlanTab;}

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            therm.GenerateTherm();
            double t = therm.GetTherm();
            label1.Text = t.ToString();
            label1.ForeColor = therm.GenerateColor();
            if (therm.Message() != null) { MessageBox.Show(therm.Message()); button1.Visible = false; }
            else { button1.Visible = true; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = inside;
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = false;

            this.BackgroundImage = tabcontrol.SelectedTab.BackgroundImage;
            this.BackgroundImageLayout = tabcontrol.SelectedTab.BackgroundImageLayout;
            if (tabcontrol.SelectedTab == PlanTab) { planPanel.init(planList); }
            else if (tabcontrol.SelectedTab == efoodtab) { init_foodlist(); orderPanel.init(orders);
                foodPanel.init(foodlist); }
            else if (tabcontrol.SelectedTab == panelroom) { init_panel(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = outside;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = panelroom;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = inside;

        }

        void init_lights()
        {
            if (smarthome.Lights)
            {
                panelroom.BackgroundImage = Properties.Resources.controll_room;
                inside.BackgroundImage = Properties.Resources.living_room;
            }
            else
            {
                panelroom.BackgroundImage = Properties.Resources.controll_room_dark;
                inside.BackgroundImage = Properties.Resources.living_room_dark;
            }

            this.BackgroundImage = tabcontrol.SelectedTab.BackgroundImage;
            this.BackgroundImageLayout = tabcontrol.SelectedTab.BackgroundImageLayout;
        }

        void init_panel()
        {
            checkLights.Checked = smarthome.Lights;
            checkRad.Checked = smarthome.Radio;
            checkTV.Checked = smarthome.Tv;
            checkCoff.Checked = smarthome.Coffee;
            checkBoiler.Checked = smarthome.Boiler;
            double t = Math.Round(smarthome.Thermostat, 1);
            therm_label.Text = t.ToString();
            int t_int = Convert.ToInt32(t * 10);
            thermBar1.Value = t_int;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        private void checkRad_CheckedChanged(object sender, EventArgs e)
        {
            smarthome.Radio = checkRad.Checked;
        }

        private void checkTV_CheckedChanged(object sender, EventArgs e)
        {
            smarthome.Tv = checkTV.Checked;
        }

        private void checkCoff_CheckedChanged(object sender, EventArgs e)
        {
            smarthome.Coffee = checkCoff.Checked;
        }

        private void checkBoiler_CheckedChanged(object sender, EventArgs e)
        {
            smarthome.Boiler = checkBoiler.Checked;
        }

        private void thermBar1_ValueChanged(object sender, EventArgs e)
        {
            double t = thermBar1.Value;
            t = t / 10;
            smarthome.Thermostat = t;
            therm_label.Text = t.ToString();
        }

        private void checkLights_CheckedChanged(object sender, EventArgs e)
        {
            smarthome.Lights = checkLights.Checked;
            init_lights();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = PlanTab;
            prev = outside;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            prev = tabcontrol.SelectedTab;
            tabcontrol.SelectedTab = PlanTab;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prev = panelroom;
            tabcontrol.SelectedTab = PlanTab;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = prev;
        }


        private void button10_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null || loc_text.Text == ""|| comboBox2.SelectedItem== null) { MessageBox.Show( "Please fill in all the fields", "ERROR"); }
            else
            {
                Plan p = new Plan();
                p.Type = comboBox1.SelectedItem.ToString();
                p.Location = loc_text.Text;
                p.Transport = comboBox2.SelectedItem.ToString();
                p.Time = dateTimePicker1.Value;

                routeForm = new RouteForm(p);
                routeForm.FormClosing += new FormClosingEventHandler(routeFormClose);
                routeForm.Show();
            }
        }
        void routeFormClose(object sender,EventArgs e)
        {
            planList.Add(routeForm.Plan);

            planPanel.init(planList);
        }

        void init_foodlist() 
        {
            foodlist.Clear();

            Food food = new Food("Pizza", 6, Properties.Resources.pizza);
            foodlist.Add(food);
            food = new Food("Burger", 4.60, Properties.Resources.burger);
            foodlist.Add(food);
            food = new Food("Souvlaki", 2.50, Properties.Resources.souvlaki);
            foodlist.Add(food);
            food = new Food("Fries", 3, Properties.Resources.fries);
            foodlist.Add(food);
            food = new Food("Frape", 1.20, Properties.Resources.frape);
            foodlist.Add(food);
            food = new Food("Fredo", 1.50, Properties.Resources.frape);
            foodlist.Add(food);

        }
         void init_efood() 
        {
            orderPanel.init(orders);
            foodPanel.init(foodlist);
        }


        private void button12_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Orderlist = foodPanel.SelectedFoods;
            order.Time = System.DateTime.Now;

            finishOrder = new FinishOrderForm(order);
            finishOrder.FormClosing  += new FormClosingEventHandler(checkorderfinish);
            finishOrder.Show();
        }

        void checkorderfinish(object sender, EventArgs e)
        {
            if (finishOrder.Finish)
            {
                Order order = new Order();
                order = finishOrder.Order;
                orders.Add(order);
                orderPanel.init(orders);
            }
        }

        private void goback_Click(object sender, EventArgs e)
        {
            tabcontrol.SelectedTab = prev;
            smartphoneBtn.BringToFront();
            efoodbtn.BringToFront();
            sosbtn.BringToFront();
            helpbtn.BringToFront();
        }
    }
}

