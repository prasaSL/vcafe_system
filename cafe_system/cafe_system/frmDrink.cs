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
    public partial class frmDrink : Form
    {
        public frmDrink()
        {
            InitializeComponent();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (this.pnlDrink.Controls.Count > 0)
            {
                this.pnlDrink.Controls.RemoveAt(0);
            }
            Form f = new frmTea() as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.pnlDrink.Controls.Add(f);
            this.pnlDrink.Tag = f;
            f.Show();
        }
    }
}
