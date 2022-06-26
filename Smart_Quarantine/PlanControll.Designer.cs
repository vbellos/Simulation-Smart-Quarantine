namespace Smart_Quarantine
{
    partial class PlanControll
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.removebtn = new System.Windows.Forms.Button();
            this.transp = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(4, 5);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(90, 90);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(117, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(156, 16);
            this.title.TabIndex = 1;
            this.title.Text = "BX:Medical Purposes";
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.date.Location = new System.Drawing.Point(107, 71);
            this.date.Name = "date";
            this.date.ShowUpDown = true;
            this.date.Size = new System.Drawing.Size(101, 20);
            this.date.TabIndex = 2;
            // 
            // removebtn
            // 
            this.removebtn.Location = new System.Drawing.Point(214, 71);
            this.removebtn.Name = "removebtn";
            this.removebtn.Size = new System.Drawing.Size(75, 23);
            this.removebtn.TabIndex = 3;
            this.removebtn.Text = "Remove";
            this.removebtn.UseVisualStyleBackColor = true;
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // transp
            // 
            this.transp.AutoSize = true;
            this.transp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transp.Location = new System.Drawing.Point(98, 50);
            this.transp.Name = "transp";
            this.transp.Size = new System.Drawing.Size(83, 16);
            this.transp.TabIndex = 4;
            this.transp.Text = "Transport: ";
            // 
            // location
            // 
            this.location.AutoSize = true;
            this.location.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location.Location = new System.Drawing.Point(100, 26);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(75, 16);
            this.location.TabIndex = 5;
            this.location.Text = "Location: ";
            // 
            // PlanControll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.location);
            this.Controls.Add(this.transp);
            this.Controls.Add(this.removebtn);
            this.Controls.Add(this.date);
            this.Controls.Add(this.title);
            this.Controls.Add(this.pictureBox);
            this.Name = "PlanControll";
            this.Size = new System.Drawing.Size(300, 100);
            this.Load += new System.EventHandler(this.PlanControll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button removebtn;
        private System.Windows.Forms.Label transp;
        private System.Windows.Forms.Label location;
    }
}
