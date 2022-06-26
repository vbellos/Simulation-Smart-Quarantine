namespace Smart_Quarantine
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabcontrol = new System.Windows.Forms.TabControl();
            this.inside = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelroom = new System.Windows.Forms.TabPage();
            this.therm_label = new System.Windows.Forms.Label();
            this.thermBar1 = new System.Windows.Forms.TrackBar();
            this.checkBoiler = new System.Windows.Forms.CheckBox();
            this.checkCoff = new System.Windows.Forms.CheckBox();
            this.checkTV = new System.Windows.Forms.CheckBox();
            this.checkRad = new System.Windows.Forms.CheckBox();
            this.checkLights = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.outside = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlanTab = new System.Windows.Forms.TabPage();
            this.panel_new_plan = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.loc_text = new System.Windows.Forms.TextBox();
            this.efoodtab = new System.Windows.Forms.TabPage();
            this.goback = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.foodPanel = new Smart_Quarantine.FoodPanel();
            this.orderPanel = new Smart_Quarantine.OrderPanel();
            this.tabcontrol.SuspendLayout();
            this.inside.SuspendLayout();
            this.panelroom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermBar1)).BeginInit();
            this.outside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PlanTab.SuspendLayout();
            this.panel_new_plan.SuspendLayout();
            this.efoodtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabcontrol
            // 
            this.tabcontrol.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabcontrol.Controls.Add(this.inside);
            this.tabcontrol.Controls.Add(this.panelroom);
            this.tabcontrol.Controls.Add(this.outside);
            this.tabcontrol.Controls.Add(this.PlanTab);
            this.tabcontrol.Controls.Add(this.efoodtab);
            this.tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol.ItemSize = new System.Drawing.Size(80, 10);
            this.tabcontrol.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol.Multiline = true;
            this.tabcontrol.Name = "tabcontrol";
            this.tabcontrol.SelectedIndex = 0;
            this.tabcontrol.Size = new System.Drawing.Size(844, 501);
            this.tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabcontrol.TabIndex = 0;
            this.tabcontrol.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // inside
            // 
            this.inside.BackgroundImage = global::Smart_Quarantine.Properties.Resources.living_room;
            this.inside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inside.Controls.Add(this.button3);
            this.inside.Controls.Add(this.button2);
            this.inside.Location = new System.Drawing.Point(4, 14);
            this.inside.Name = "inside";
            this.inside.Padding = new System.Windows.Forms.Padding(3);
            this.inside.Size = new System.Drawing.Size(836, 483);
            this.inside.TabIndex = 1;
            this.inside.Text = "Inside House";
            this.inside.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(712, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 41);
            this.button3.TabIndex = 1;
            this.button3.Text = "Go to Panel Room";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Go Outside";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelroom
            // 
            this.panelroom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelroom.BackgroundImage")));
            this.panelroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelroom.Controls.Add(this.therm_label);
            this.panelroom.Controls.Add(this.thermBar1);
            this.panelroom.Controls.Add(this.checkBoiler);
            this.panelroom.Controls.Add(this.checkCoff);
            this.panelroom.Controls.Add(this.checkTV);
            this.panelroom.Controls.Add(this.checkRad);
            this.panelroom.Controls.Add(this.checkLights);
            this.panelroom.Controls.Add(this.button4);
            this.panelroom.Location = new System.Drawing.Point(4, 14);
            this.panelroom.Name = "panelroom";
            this.panelroom.Padding = new System.Windows.Forms.Padding(3);
            this.panelroom.Size = new System.Drawing.Size(836, 483);
            this.panelroom.TabIndex = 2;
            this.panelroom.Text = "Panel Room";
            this.panelroom.UseVisualStyleBackColor = true;
            // 
            // therm_label
            // 
            this.therm_label.AutoSize = true;
            this.therm_label.BackColor = System.Drawing.Color.Transparent;
            this.therm_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.therm_label.Location = new System.Drawing.Point(393, 378);
            this.therm_label.Name = "therm_label";
            this.therm_label.Size = new System.Drawing.Size(44, 20);
            this.therm_label.TabIndex = 7;
            this.therm_label.Text = "20.0";
            // 
            // thermBar1
            // 
            this.thermBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.thermBar1.Location = new System.Drawing.Point(295, 401);
            this.thermBar1.Maximum = 400;
            this.thermBar1.Name = "thermBar1";
            this.thermBar1.Size = new System.Drawing.Size(237, 45);
            this.thermBar1.TabIndex = 6;
            this.thermBar1.ValueChanged += new System.EventHandler(this.thermBar1_ValueChanged);
            // 
            // checkBoiler
            // 
            this.checkBoiler.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoiler.AutoSize = true;
            this.checkBoiler.Location = new System.Drawing.Point(488, 332);
            this.checkBoiler.Name = "checkBoiler";
            this.checkBoiler.Size = new System.Drawing.Size(43, 23);
            this.checkBoiler.TabIndex = 5;
            this.checkBoiler.Text = "Boiler";
            this.checkBoiler.UseVisualStyleBackColor = true;
            this.checkBoiler.CheckedChanged += new System.EventHandler(this.checkBoiler_CheckedChanged);
            // 
            // checkCoff
            // 
            this.checkCoff.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCoff.AutoSize = true;
            this.checkCoff.Location = new System.Drawing.Point(434, 332);
            this.checkCoff.Name = "checkCoff";
            this.checkCoff.Size = new System.Drawing.Size(48, 23);
            this.checkCoff.TabIndex = 4;
            this.checkCoff.Text = "Coffee";
            this.checkCoff.UseVisualStyleBackColor = true;
            this.checkCoff.CheckedChanged += new System.EventHandler(this.checkCoff_CheckedChanged);
            // 
            // checkTV
            // 
            this.checkTV.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTV.AutoSize = true;
            this.checkTV.Location = new System.Drawing.Point(397, 332);
            this.checkTV.Name = "checkTV";
            this.checkTV.Size = new System.Drawing.Size(31, 23);
            this.checkTV.TabIndex = 3;
            this.checkTV.Text = "TV";
            this.checkTV.UseVisualStyleBackColor = true;
            this.checkTV.CheckedChanged += new System.EventHandler(this.checkTV_CheckedChanged);
            // 
            // checkRad
            // 
            this.checkRad.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkRad.AutoSize = true;
            this.checkRad.Location = new System.Drawing.Point(346, 332);
            this.checkRad.Name = "checkRad";
            this.checkRad.Size = new System.Drawing.Size(45, 23);
            this.checkRad.TabIndex = 2;
            this.checkRad.Text = "Radio";
            this.checkRad.UseVisualStyleBackColor = true;
            this.checkRad.CheckedChanged += new System.EventHandler(this.checkRad_CheckedChanged);
            // 
            // checkLights
            // 
            this.checkLights.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkLights.AutoSize = true;
            this.checkLights.Location = new System.Drawing.Point(295, 332);
            this.checkLights.Name = "checkLights";
            this.checkLights.Size = new System.Drawing.Size(45, 23);
            this.checkLights.TabIndex = 1;
            this.checkLights.Text = "Lights";
            this.checkLights.UseVisualStyleBackColor = true;
            this.checkLights.CheckedChanged += new System.EventHandler(this.checkLights_CheckedChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(32, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 45);
            this.button4.TabIndex = 0;
            this.button4.Text = "Get Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // outside
            // 
            this.outside.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("outside.BackgroundImage")));
            this.outside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.outside.Controls.Add(this.button1);
            this.outside.Controls.Add(this.label1);
            this.outside.Controls.Add(this.pictureBox1);
            this.outside.Location = new System.Drawing.Point(4, 14);
            this.outside.Name = "outside";
            this.outside.Padding = new System.Windows.Forms.Padding(3);
            this.outside.Size = new System.Drawing.Size(836, 483);
            this.outside.TabIndex = 0;
            this.outside.Text = "Outside House";
            this.outside.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(380, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter The House";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(196, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "36.6";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(567, 142);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 113);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlanTab
            // 
            this.PlanTab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlanTab.BackgroundImage")));
            this.PlanTab.Controls.Add(this.panel_new_plan);
            this.PlanTab.Location = new System.Drawing.Point(4, 14);
            this.PlanTab.Name = "PlanTab";
            this.PlanTab.Padding = new System.Windows.Forms.Padding(3);
            this.PlanTab.Size = new System.Drawing.Size(836, 483);
            this.PlanTab.TabIndex = 3;
            this.PlanTab.Text = "PlanTab";
            this.PlanTab.UseVisualStyleBackColor = true;
            // 
            // panel_new_plan
            // 
            this.panel_new_plan.Controls.Add(this.button10);
            this.panel_new_plan.Controls.Add(this.label5);
            this.panel_new_plan.Controls.Add(this.label4);
            this.panel_new_plan.Controls.Add(this.label3);
            this.panel_new_plan.Controls.Add(this.comboBox2);
            this.panel_new_plan.Controls.Add(this.label2);
            this.panel_new_plan.Controls.Add(this.comboBox1);
            this.panel_new_plan.Controls.Add(this.dateTimePicker1);
            this.panel_new_plan.Controls.Add(this.loc_text);
            this.panel_new_plan.Location = new System.Drawing.Point(160, 105);
            this.panel_new_plan.Name = "panel_new_plan";
            this.panel_new_plan.Size = new System.Drawing.Size(254, 257);
            this.panel_new_plan.TabIndex = 16;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(62, 211);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(122, 33);
            this.button10.TabIndex = 21;
            this.button10.Text = "Add New Plan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Means Of Transport";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Location:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Car",
            "Motorcycle",
            "Bicycle",
            "Bus",
            "Feet",
            "Teleport"});
            this.comboBox2.Location = new System.Drawing.Point(63, 136);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type Of Transport:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Β1: Medical Purposes",
            "B2: Shopping ",
            "B3: Public Service",
            "B4: Provide Assistanse",
            "B5: Funeral",
            "B6: Personal Excersise"});
            this.comboBox1.Location = new System.Drawing.Point(63, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 184);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // loc_text
            // 
            this.loc_text.Location = new System.Drawing.Point(62, 87);
            this.loc_text.Name = "loc_text";
            this.loc_text.Size = new System.Drawing.Size(121, 20);
            this.loc_text.TabIndex = 14;
            // 
            // efoodtab
            // 
            this.efoodtab.BackColor = System.Drawing.Color.Red;
            this.efoodtab.Controls.Add(this.goback);
            this.efoodtab.Controls.Add(this.button12);
            this.efoodtab.Controls.Add(this.foodPanel);
            this.efoodtab.Controls.Add(this.orderPanel);
            this.efoodtab.Location = new System.Drawing.Point(4, 14);
            this.efoodtab.Name = "efoodtab";
            this.efoodtab.Padding = new System.Windows.Forms.Padding(3);
            this.efoodtab.Size = new System.Drawing.Size(836, 483);
            this.efoodtab.TabIndex = 4;
            this.efoodtab.Text = "efood";
            // 
            // goback
            // 
            this.goback.Location = new System.Drawing.Point(663, 435);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(75, 23);
            this.goback.TabIndex = 6;
            this.goback.Text = "Go Back";
            this.goback.UseVisualStyleBackColor = true;
            this.goback.Click += new System.EventHandler(this.goback_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(744, 435);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 3;
            this.button12.Text = "Order";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // foodPanel
            // 
            this.foodPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodPanel.Location = new System.Drawing.Point(263, 3);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(570, 413);
            this.foodPanel.TabIndex = 5;
            // 
            // orderPanel
            // 
            this.orderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderPanel.Location = new System.Drawing.Point(3, 3);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(260, 477);
            this.orderPanel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 501);
            this.Controls.Add(this.tabcontrol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Smart Quarantine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabcontrol.ResumeLayout(false);
            this.inside.ResumeLayout(false);
            this.panelroom.ResumeLayout(false);
            this.panelroom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thermBar1)).EndInit();
            this.outside.ResumeLayout(false);
            this.outside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PlanTab.ResumeLayout(false);
            this.panel_new_plan.ResumeLayout(false);
            this.panel_new_plan.PerformLayout();
            this.efoodtab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcontrol;
        private System.Windows.Forms.TabPage inside;
        private System.Windows.Forms.TabPage panelroom;
        private System.Windows.Forms.TabPage outside;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBoiler;
        private System.Windows.Forms.CheckBox checkCoff;
        private System.Windows.Forms.CheckBox checkTV;
        private System.Windows.Forms.CheckBox checkRad;
        private System.Windows.Forms.CheckBox checkLights;
        private System.Windows.Forms.Label therm_label;
        private System.Windows.Forms.TrackBar thermBar1;
        private System.Windows.Forms.TabPage PlanTab;
        private System.Windows.Forms.Panel panel_new_plan;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox loc_text;
        private System.Windows.Forms.TabPage efoodtab;
        private System.Windows.Forms.Button button12;
        private OrderPanel orderPanel;
        private FoodPanel foodPanel;
        private System.Windows.Forms.Button goback;

    }
}

