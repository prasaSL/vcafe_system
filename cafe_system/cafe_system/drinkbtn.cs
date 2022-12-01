using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  cafe_system;

namespace cafe_system
{
    public partial class drinkbtn : UserControl
    {
        public drinkbtn()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            this.tea1.Visible = true;
            this.shakes1.Visible = false;
        }

        private void button35_Click(object sender, EventArgs e)
        {

        }

        private void drinkbtn_Load(object sender, EventArgs e)
        {

        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.shakes1.Visible = true;
            this.tea1.Visible = false;

           
            
        }
    }
}
