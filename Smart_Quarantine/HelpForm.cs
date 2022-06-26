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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fname.Text !="" && email.Text !="" && issue.Text != "")
            {
                MessageBox.Show("Submited", "Thank you for contacting us");
            }
            else { MessageBox.Show("Please Fill in all the fields"); }
        }
    }
}
