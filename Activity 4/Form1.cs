using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            int seconds;
            if(int.TryParse(secondsBox.Text, out seconds)) 
            {
                if(seconds >= 86400)
                {
                    MessageBox.Show(seconds / 86400 + " day(s).");
                } else if (seconds >= 3600)
                {
                    MessageBox.Show(seconds / 3600 + " hour(s).");
                }
                else if (seconds >= 60)
                {
                    MessageBox.Show(seconds / 60 + " minute(s).");
                } else
                {
                    MessageBox.Show(seconds + " second(s).");
                }
            } else 
            {
                MessageBox.Show("Enter a valid number.");
            }
        }
    }
}
