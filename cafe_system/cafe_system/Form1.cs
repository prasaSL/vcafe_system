using System;
using System.Collections.Generic;
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
        SqlConnection con;


        public logForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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
                        SqlCommand cmd1 = new SqlCommand("select * from Vuser where Uname = @user", con);
                        cmd1.Parameters.AddWithValue("@user", userTbox.Text);
                        SqlDataReader reader;
                        reader = cmd1.ExecuteReader();
                        if (reader.Read())
                        {
                            Program.user = reader["Uname"].ToString();
                            Program.position = reader["Vtype"].ToString();
                            workarsForm obj = new workarsForm();
                            obj.Show();
                            this.Hide();
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
    }
}
