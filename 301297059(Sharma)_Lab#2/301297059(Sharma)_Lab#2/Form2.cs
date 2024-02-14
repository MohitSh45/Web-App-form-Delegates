using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _301297059_Sharma__Lab_2
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Subscribe_Click(object sender, EventArgs e)
        {
            string email = Mail.Text.Trim();
            string mobile = Phone.Text.Trim();

            if (!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(mobile))
            {
                form1.Subscribe(email, mobile);
                MessageBox.Show("Subscription successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please provide either an email address or a mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();  
        }

        private void Unsubscribe_Click(object sender, EventArgs e)
        {
            string email = Mail.Text.Trim();
            string mobile = Phone.Text.Trim();

            if (!string.IsNullOrEmpty(email) || !string.IsNullOrEmpty(mobile))
            {
                form1.Unsubscribe(email, mobile);
                MessageBox.Show("Unsubscription successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please provide either an email address or a mobile number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Close();
        }
    }
}
