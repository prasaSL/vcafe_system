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
    public partial class product : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Vcafe_SystemDB;Integrated Security=True");

        private static product _product;
        public static product _pro
        {
            get
            {
                if (_product == null)
                    _product = new product();
                return _product;
                {

                }
            }
        }
        public product()
        {
            InitializeComponent();
        }
        private void Display()
        {
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT ItemId as 'Item ID' , itemName as 'Item Name' , price as 'Price' FROM Item ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            pro_dg.DataSource = dtbl;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();

                String query_search = "select * from item where itemid ='" + txtiid.Text + "'";
                SqlCommand cmnd = new SqlCommand(query_search, con);
                SqlDataReader r = cmnd.ExecuteReader();
                while (r.Read())
                {
                    txtiname.Text = r[1].ToString();
                    txtiprice.Text = r[2].ToString();

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmnd = new SqlCommand("update Item set itemname ='" + txtiname.Text + "',price='" + txtiprice.Text + "'where itemid='" + txtiid.Text + "'", con);
            cmnd.ExecuteNonQuery();
            MessageBox.Show("Updated !");
            Display();
            txtiname.Text = "";
            txtiprice.Text = "";

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (comtype.Text == "Item ID")
            {

                string com = comtype.Text;
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Item where itemid like '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                pro_dg.DataSource = dt;
                con.Close();

            }
            else if (comtype.Text == "Item Name")
            {
                string com = comtype.Text;
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Item where itemname like '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                pro_dg.DataSource = dt;
            }
            else if (comtype.Text == "Price")
            {
                string com = comtype.Text;
                SqlDataAdapter adapt = new SqlDataAdapter("select * from Item where price like '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                pro_dg.DataSource = dt;
            }
            con.Close();
        }
    }
}
