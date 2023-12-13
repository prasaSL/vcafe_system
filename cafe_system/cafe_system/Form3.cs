using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public partial class Form3 : Form
    {
        SqlConnection con = connectionManager.getconn();

        bool sliderexp;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Form3()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
            if (!main_p.Controls.Contains(dashboard._dash))
            {
                main_p.Controls.Add(dashboard._dash);
                dashboard._dash.Dock = DockStyle.Fill;
                dashboard._dash.BringToFront();
            }
            else
            {
                dashboard._dash.BringToFront();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_acc_Click(object sender, EventArgs e)
        {
           
            if (!main_p.Controls.Contains(account._acc))
            {
                main_p.Controls.Add(account._acc);
                account._acc.Dock = DockStyle.Fill;
                account._acc.BringToFront();
            }
            else
            {
                account._acc.BringToFront();
            }
        }

        private void btn_inve_Click(object sender, EventArgs e)
        {

           
            if (!main_p.Controls.Contains(inventory._inv))
            {
                main_p.Controls.Add(inventory._inv);
                inventory._inv.Dock = DockStyle.Fill;
                inventory._inv.BringToFront();
            }
            else
            {
                inventory._inv.BringToFront();
            }
        }

        private void btn_pro_Click(object sender, EventArgs e)
        {
            
            if (!main_p.Controls.Contains(product._pro))
            {
                main_p.Controls.Add(product._pro);
                product._pro.Dock = DockStyle.Fill;
                product._pro.BringToFront();
            }
            else
            {
                product._pro.BringToFront();
            }
        }

        private void btn_user_log_Click(object sender, EventArgs e)
        {

         
            if (!main_p.Controls.Contains(userlog._log))
            {
                main_p.Controls.Add(userlog._log);
                userlog._log.Dock = DockStyle.Fill;
                userlog._log.BringToFront();
            }
            else
            {
                userlog._log.BringToFront();
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are You sure want to Logout", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                string sql = "INSERT INTO user_log  VALUES('" + mname.Text + "',getdate(),'Logout')";
                SqlCommand cmnd = new SqlCommand(sql, con);

                cmnd.ExecuteNonQuery();
                con.Close();
                logForm lf = new logForm();
                lf.Show();
                this.Hide();

            }
            else if (rs == DialogResult.No)
            {

            }
        }

        private void main_p_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            mname.Text = logForm.username;
        }

        private void slidetime_Tick(object sender, EventArgs e)
        {
            if (sliderexp)
            {
                slidebar.Width -= 10;
                iconm.Width -= 10;
                if (slidebar.Width == slidebar.MinimumSize.Width)
                {
                    sliderexp = false;
                    slidetime.Stop();
                    mname.Visible = false;

                }
            }
            else
            {
                slidebar.Width += 10;
                iconm.Width += 10;
                if (slidebar.Width == slidebar.MaximumSize.Width)
                {
                    sliderexp = true;
                    mname.Visible = true;
                    slidetime.Stop();
                }
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            slidetime.Start();            
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnToCashier_Click(object sender, EventArgs e)
        {
            workarsForm w = new workarsForm();
            w.Show();
            this.Hide();
        }
    }
}
