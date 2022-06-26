namespace Smart_Quarantine
{
    partial class FoodPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title_label = new System.Windows.Forms.Label();
            this.Titlepanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.Titlepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_label.Location = new System.Drawing.Point(223, 8);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(103, 20);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "New  Order:";
            // 
            // Titlepanel
            // 
            this.Titlepanel.AutoScroll = true;
            this.Titlepanel.Controls.Add(this.title_label);
            this.Titlepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlepanel.Location = new System.Drawing.Point(0, 0);
            this.Titlepanel.Name = "Titlepanel";
            this.Titlepanel.Size = new System.Drawing.Size(560, 35);
            this.Titlepanel.TabIndex = 2;
            this.Titlepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 35);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(560, 305);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint_1);
            // 
            // FoodPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Titlepanel);
            this.Name = "FoodPanel";
            this.Size = new System.Drawing.Size(560, 340);
            this.Titlepanel.ResumeLayout(false);
            this.Titlepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Panel Titlepanel;
        private System.Windows.Forms.Panel panel;
    }
}
