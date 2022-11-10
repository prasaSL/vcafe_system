using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void splashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int step = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    //Enabled = false;
                    timer1.Interval = 2000;
                    break;

                case 1:
                    lblMsg.Text = "Database loading";
                    lblMsg.ForeColor = Color.White;
                    break;

                case 2:
                    lblMsg.Text = "Accounts loading";
                    break;

                case 3:
                    lblMsg.Text = "System starting...100%";
                    break;

                case 4:
                    this.Close();
                    break;
            }
            step++;
        }

        
    }
}
