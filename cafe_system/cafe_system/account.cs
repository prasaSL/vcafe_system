using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafe_system
{
    public partial class account : UserControl
    {
        SqlConnection con = connectionManager.getconn();
        private static account _account;
        public static account _acc
        {
            get
            {
                if (_account == null)
                    _account = new account();
                return _account;
                {

                }
            }
        }
        public account()
        {
            InitializeComponent();
        }
        private void autoin()
        {


            SqlCommand cmd = new SqlCommand("select max(Uid)+1 from Vuser", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            txtuid.Text = i.ToString();

        }
        private void display()
        {

            {

                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT Uid as 'User ID', Uname as 'User Name', Vtype as 'User Type' FROM Vuser ", con);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                acc_dg.DataSource = dtbl;

            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                String u_id = txtuid.Text;
                String query_search = "select * from vuser where Uid ='" + u_id + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtuname.Text = r[1].ToString();
                    txtpass.Text = r[2].ToString();
                    txtcpass.Text = r[2].ToString();
                    comtype.Text = r[3].ToString();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        void StyleDatagridview()
        {
            acc_dg.BorderStyle = BorderStyle.None;
            acc_dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            acc_dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            acc_dg.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            acc_dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            acc_dg.EnableHeadersVisualStyles = false;
            acc_dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            acc_dg.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            acc_dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 182, 182);
            acc_dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {

                String name = txtuname.Text;
                String pass = txtpass.Text;
                String cpass = txtcpass.Text;
                String type = comtype.Text;

                if (pass == cpass)
                {



                    String query_insert = ("insert into Vuser values('" + name + "','" + pass + "','" + type + "')");
                    SqlCommand cmnd = new SqlCommand(query_insert, con);
                    con.Open();
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Saved Sucessfully!!");


                    autoin();
                    display();
                    txtuname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    comtype.Text = "";

                }
                else
                {
                    MessageBox.Show("Password not Match");
                    //txtuname.Text = "";
                    txtpass.Text = "";
                    txtcpass.Text = "";
                    //comtype.Text = "";

                }
            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
            finally
            {
                con.Close();
            }

        }

        private void account_Load(object sender, EventArgs e)
        {
            con.Open();
            autoin();
            display();
            con.Close();
            StyleDatagridview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == txtcpass.Text)
            {


                con.Open();
                SqlCommand cmnd = new SqlCommand("update Vuser set Uname='" + txtuname.Text + "',vpass='" + txtpass.Text + "',vtype='" + comtype.Text + "'where Uid='" + txtuid.Text + "'", con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("Updated !");

                autoin();
                display();
                con.Close();
                txtuname.Text = "";
                txtpass.Text = "";
                txtcpass.Text = "";
                comtype.Text = "";
            }
            else
            {
                MessageBox.Show("Password did not matched");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Are You sure want to Delete user", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (rs == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmnd = new SqlCommand("Delete from Vuser where Uid ='" + txtuid.Text + "'", con);
                cmnd.ExecuteNonQuery();
                MessageBox.Show("User Removed !! ");

                display();
                txtuname.Text = "";
                txtpass.Text = "";
                txtcpass.Text = "";
                comtype.Text = "";
                con.Close();

            }
            else if (rs == DialogResult.No)
            {

            }
        }
    }
}
