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
    public partial class dashboard : UserControl
    {
        SqlConnection con = connectionManager.getconn();

        private static dashboard _dashboard;
        public static dashboard _dash
        {
            get
            {
                if (_dashboard == null)
                    _dashboard = new dashboard();
                return _dashboard;
                {

                }
            }
        }
        private void total()
        {
            con.Open();
            SqlCommand command = new SqlCommand("SELECT sum(bill_total) FROM bill_infor", con);
            SqlDataReader dr = command.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(command);
            if (dr.Read())
            {
                lbl_total.Text = dr[0].ToString();
            }
            con.Close();
        }
        private void Display()
        {
            con.Open();
            SqlDataAdapter sqldata = new SqlDataAdapter("SELECT * FROM user_log where status = 'login' ", con);
            DataTable dtbl = new DataTable();
            sqldata.Fill(dtbl);
            user_log.DataSource = dtbl;
            con.Close();
        }
        private void display_acc()
        {

            {

                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT Uid as 'User ID', Uname as 'User Name', Vtype as 'User Type' FROM Vuser ", con);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                data_acc.DataSource = dtbl;

            }
        }
        public dashboard()
        {
            InitializeComponent();
        }
        void StyleDatagridview()
        {
            user_log.BorderStyle = BorderStyle.None;
            user_log.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            user_log.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            user_log.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            user_log.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            // user_log.BackgroundColor = Color.FromArgb(30, 30, 30);
            // user_log.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;//optional
            user_log.EnableHeadersVisualStyles = false;
            user_log.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            user_log.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            user_log.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 182, 182);
            user_log.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
        }
        void StyleDatagridview_acc()
        {
            data_acc.BorderStyle = BorderStyle.None;
            data_acc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            data_acc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            data_acc.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            data_acc.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            data_acc.EnableHeadersVisualStyles = false;
            data_acc.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            data_acc.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            data_acc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 182, 182);
            data_acc.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            total();
            Display();
            StyleDatagridview();
            StyleDatagridview_acc();
            display_acc();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            con.Open();
            // what should I write here for comparing the date?
            SqlCommand command = new SqlCommand("select sum(bill_total) from bill_infor where date between '" + date_start.Value.ToString("MM/dd/yyyy") + "' and '" + date_end.Value.ToString("MM/dd/yyyy") + "'", con);

            // then set these values
            SqlDataReader dr = command.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(command);
            if (dr.Read())
            {
                lblcus.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void btday_Click(object sender, EventArgs e)
        {
            con.Open();
            // what should I write here for comparing the date?
            SqlCommand command = new SqlCommand("select sum(bill_total) from bill_infor where date  between GETDATE()-1 and GETDATE() ", con);

            // then set these values
            SqlDataReader dr = command.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(command);
            if (dr.Read())
            {
                lblcus.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void btn7day_Click(object sender, EventArgs e)
        {
            con.Open();
            // what should I write here for comparing the date?
            SqlCommand command = new SqlCommand("select sum(bill_total) from bill_infor where date  between GETDATE()-7 and GETDATE() ", con);

            // then set these values
            SqlDataReader dr = command.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(command);
            if (dr.Read())
            {
                lblcus.Text = dr[0].ToString();
            }
            con.Close();
        }

        private void btnmonth_Click(object sender, EventArgs e)
        {
            con.Open();
            // what should I write here for comparing the date?
            SqlCommand command = new SqlCommand("select sum(bill_total) from bill_infor where date  between GETDATE()-30 and GETDATE() ", con);

            // then set these values
            SqlDataReader dr = command.ExecuteReader();
            SqlDataAdapter da = new SqlDataAdapter(command);
            if (dr.Read())
            {
                lblcus.Text = dr[0].ToString();
            }
            con.Close();
        }
    }
}
