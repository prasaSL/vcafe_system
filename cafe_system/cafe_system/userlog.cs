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
    public partial class userlog : UserControl
    {
        SqlConnection con = connectionManager.getconn();
        private static userlog _userlog;
        public static userlog _log
        {
            get
            {
                if (_userlog == null)
                    _userlog = new userlog();
                return _userlog;
                {

                }
            }
        }

        public userlog()
        {
            InitializeComponent();
        }
        private void display()
        {

            {

                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT * FROM user_log ", con);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                ulog_dg.DataSource = dtbl;

            }
        }
        void StyleDatagridview()
        {
            ulog_dg.BorderStyle = BorderStyle.None;
            ulog_dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            ulog_dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            ulog_dg.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            ulog_dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            ulog_dg.EnableHeadersVisualStyles = false;
            ulog_dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            ulog_dg.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            ulog_dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 182, 182);
            ulog_dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
        }

        private void userlog_Load(object sender, EventArgs e)
        {
            con.Open();
            display();
            con.Close();
            StyleDatagridview();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            if (comtype.Text == "user")
            {

                string com = comtype.Text;
                SqlDataAdapter adapt = new SqlDataAdapter("select * from user_log where [user] like '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                ulog_dg.DataSource = dt;
                con.Close();

            }
            else if (comtype.Text == "status")
            {
                string com = comtype.Text;
                SqlDataAdapter adapt = new SqlDataAdapter("select * from user_log where status like '" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                adapt.Fill(dt);
                ulog_dg.DataSource = dt;
            }

            con.Close();
        }
    }
}
