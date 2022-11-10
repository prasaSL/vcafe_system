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
    public partial class workarsForm : Form
    {
        public workarsForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
     

        }

        private void workarsForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDate.Text = now.ToString("F");
          
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            
        }
    }
}
