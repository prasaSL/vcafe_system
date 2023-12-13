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
    public partial class inventory : UserControl
    {
        string connecctionS = @"Data Source=.\;Initial Catalog=Vcafe_SystemDB;Integrated Security=True";
        private static inventory _inventory;
        public static inventory _inv
        {
            get
            {
                if (_inventory == null)
                    _inventory = new inventory();
                return _inventory;
                {

                }
            }
        }
        void StyleDatagridview()
        {
            inven_dg.BorderStyle = BorderStyle.None;
            inven_dg.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            inven_dg.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            inven_dg.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            inven_dg.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            inven_dg.EnableHeadersVisualStyles = false;
            inven_dg.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            inven_dg.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 12);

            inven_dg.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(194, 182, 182);
            inven_dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(34, 34, 34);
        }
        public inventory()
        {
            InitializeComponent();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            StyleDatagridview();
            using (SqlConnection sqlcon = new SqlConnection(connecctionS))
            {
                sqlcon.Open();
                SqlDataAdapter sqldata = new SqlDataAdapter("SELECT Inv_ID as 'Item ID',Inv_Name 'Item Name',Inv_Qty'Quntitiy',inv_unit 'unit',Inv_AddDate'enterd date'FROM InveItems ", sqlcon);
                DataTable dtbl = new DataTable();
                sqldata.Fill(dtbl);
                inven_dg.DataSource = dtbl;
            }
        }
    }
}
