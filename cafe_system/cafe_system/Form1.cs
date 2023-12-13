using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace cafe_system
{
    public partial class logForm : Form
    {

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

        SqlConnection con;
       public static string username = "";

        public logForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
             

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userTbox.Text = "";
            passTbox.Text = "";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (userTbox.Text == "")
                {
                    MessageBox.Show("user name can't be empty");
                }
                else if (passTbox.Text == "")
                {
                    MessageBox.Show("password can't be empty");
                }
                else
                {
                    con = connectionManager.getconn();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Vuser where Uname = @user and Vpass = @pass", con);
                    cmd.Parameters.AddWithValue("@user", userTbox.Text);
                    cmd.Parameters.AddWithValue("@pass", passTbox.Text);
                    SqlDataAdapter dat = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dat.Fill(dt);

                    
                    if (dt.Rows.Count > 0)
                    {
                        username = userTbox.Text;
                        SqlCommand cmd1 = new SqlCommand("select * from Vuser where Uname = @user", con);
                        cmd1.Parameters.AddWithValue("@user", userTbox.Text);
                        SqlDataReader reader;
                        reader = cmd1.ExecuteReader();
                        if (reader.Read())
                        {
                            Program.user = reader["Uname"].ToString();
                            Program.position = reader["Vtype"].ToString();
                            reader.Close();
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO user_log VALUES(@user,getdate(), 'login' )",con);
                            cmd2.Parameters.AddWithValue("@user", userTbox.Text);
                            cmd2.ExecuteNonQuery();
                            

                            if (Program.position == "admin")
                            {
                                Form3 ob = new Form3();
                                ob.Show();
                                this.Hide();

                            }
                            else
                            {
                                workarsForm obj = new workarsForm();
                                obj.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("wrong user name or password");
                    }

                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            

        }

        private void btnLog_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void btnLog_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void logForm_Load(object sender, EventArgs e)
        {

        }
    }
}
