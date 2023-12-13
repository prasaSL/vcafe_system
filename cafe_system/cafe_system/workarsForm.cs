using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Data;
using System.Drawing;

namespace cafe_system
{
    public partial class workarsForm : Form
    {
        public double count = 0;
        public double price = 0;
        public int index = 0;
        public double totalp;
        public double billtotal;
        public int k = 0;
   

        IDictionary<string, double> prices = new Dictionary<string, double>();
        DataTable btable =new DataTable();
        DataTable res = new DataTable();
        public SqlConnection con;

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


        public workarsForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void workarsForm_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblDate.Text = now.ToString("F");
            con = connectionManager.getconn();

            con.Open();
            try
            {
                foreach (KeyValuePair<string, string> i in namelist.itemlist)
                {
                    string  price;
                    SqlCommand cmd = new SqlCommand("select * from Item where itemName = @Iname", con);
                    cmd.Parameters.AddWithValue("@Iname", i.Value);
                    SqlDataReader reader;
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //price1 = reader["price"].ToString();
                        price = String.Format("{0:0.00}", reader["price"]);
                        Control[] a = this.Controls.Find(i.Key, true);
                        a[0].Text = price;
                        prices.Add(i.Value, Convert.ToDouble(price));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //   this.WindowState = FormWindowState.Maximized;
            //   this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            lbluser.Text = Program.user;
            gbdrink.Show();
            gbFood.Hide();
            gbTea.Show();
            gbshakes.Hide();
            gbCofee.Hide();
            gbsoftdrink.Hide();
            gbsandwich.Hide();
            gbburger.Hide();
            gbsoup.Hide();
            gbHotDog.Hide();
            gbsoftdrink.Hide();
            gbtopping.Hide();
            gborder.Hide();
            DataColumn column = new DataColumn();
            column.ColumnName = "NO";
            
            column.DataType = System.Type.GetType("System.Int32");
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;
            btable.Columns.Add(column);
            btable.Columns.Add("Item",typeof(string));
            btable.Columns.Add("QUANTITY",typeof(double));
            btable.Columns.Add("price",typeof(double));

            btable.PrimaryKey = new DataColumn[] { btable.Columns["NO"] };
           
            bill.DataSource=btable;
            try
            {
                DataTable s = new DataTable();
                con = connectionManager.getconn();

                con.Open();
                SqlCommand cmd4 = new SqlCommand("select Inv_ID,Inv_Name,Inv_Qty from InveItems", con);
                SqlDataReader reader1 = cmd4.ExecuteReader();
                gbupdatestorage.Show();
                gbupdatestorage.BringToFront();
                s.Load(reader1);
                dgstore.DataSource = s;
                dgcurrent.DataSource = s;

                if (Program.position == "admin") {
                    btnbacktoAdmin.Visible = true;
                }

                else if (Program.position == "cashier")
                {
                    btnSUp.Enabled = false;
                    btnSHistry.Enabled = false;
                    //btnToday.Enabled = false;
                    gbupdatestorage.Enabled = false;
                    pnlInventory.Hide();
                }
                else
                {
                    btncashiar.Enabled = false;
                    pnlCashier.Hide();
                    gbupdatestorage.Hide();
                    gbCStorage.Show();
                    gbhistory.Hide();
                    con = connectionManager.getconn();

                    con.Open();
                    SqlCommand cmd6 = new SqlCommand("select Inv_ID,Inv_Name,Inv_Qty,inv_unit from InveItems", con);
                    SqlDataAdapter a = new SqlDataAdapter(cmd6);
                    DataTable dt = new DataTable();
                    a.Fill(dt);
                    cBoxItem.DisplayMember = "Inv_Name";
                    cBoxItem.DataSource = dt;
                    dgstore.DataSource = dt;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
        public void lordmainpanal(object Form)
        {


        }

        private void btnDrink_Click(object sender, EventArgs e)
        {
            gbdrink.Show();
            gbFood.Hide();
            gbTea.Show();
            gbsandwich.Hide();
            gbburger.Hide();
            gbsoup.Hide();
            gbHotDog.Hide();
            gbsoftdrink.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbdrink.Hide();
            gbFood.Show();
            gbTea.Hide();
            gbsandwich.Show();
            gbshakes.Hide();
            gbTea.Hide();
            gbCofee.Hide();
            gbsoftdrink.Hide();
            gbHotDog.Hide();
            gbtopping.Hide();

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foodbtn1_Load(object sender, EventArgs e)
        {

        }

        private void drinkbtn1_Load(object sender, EventArgs e)
        {

        }

        private void drinkbtn1_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlCashier_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (lblcount.Text == "" ||lblOName.Text == "" || lblprice.Text=="")
            {
                MessageBox.Show("pleace  fill requrid feeld");
            }
            else{
                bool run = false;
                string item = lblOName.Text;
                billtotal = billtotal + totalp;
                index = index +1;
          run=namelist.stor(count);
                if (run ==true)
                {

                    DataRow workRow = btable.NewRow();
                    workRow["Item"] = item;
                    workRow["QUANTITY"] = count;
                    workRow["price"] = totalp;
                    btable.Rows.Add(workRow);

                    lblBtotal.Text = String.Format("{0:0.00}", billtotal);
                    lblOName.Text = "";
                    lblcount.Text = "";
                    lblprice.Text = "";
                    lbltotal.Text = "";

                }
                
                gborder.Hide();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            string t = lblcount.Text;
            if (t.Length < 1)
            {
                MessageBox.Show("there no number");
            }
            else
            {
                t = t.Remove(t.Length - 1);
                if (t.Length == 0)
                {
                    count = 0;
                    lblcount.Text = "";
                }
                else
                {
                    lblcount.Text = t;
                    count = Convert.ToDouble(lblcount.Text);

                }
                totalp = price * count;
                lbltotal.Text = string.Format("{0:0.00}", totalp);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void btntea_Click(object sender, EventArgs e)
        {
            gbTea.Show();
            gbshakes.Hide();
            gbCofee.Hide();
            gbsoftdrink.Hide();
        }

        private void btncofee_Click(object sender, EventArgs e)
        {
            gbTea.Hide();
            gbshakes.Hide();
            gbCofee.Show();
            gbsoftdrink.Hide();
        }

        private void btnshakes_Click(object sender, EventArgs e)
        {

            gbTea.Hide();
            gbshakes.Show();
            gbCofee.Hide();
            gbsoftdrink.Hide();
        }

        private void btnsoftdrink_Click(object sender, EventArgs e)
        {
            gbTea.Hide();
            gbshakes.Hide();
            gbCofee.Hide();
            gbsoftdrink.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            gbsandwich.Show();
            gbsoup.Hide();
            gbburger.Hide();
            gbHotDog.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button54_Click(object sender, EventArgs e)
        {
            gbsoup.Show();
            gbsandwich.Hide();
            gbburger.Hide();
            gbHotDog.Hide();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            gbsoup.Hide();
            gbsandwich.Hide();
            gbburger.Show();
            gbHotDog.Hide();
        }

        private void gbsoftdrink_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button52_Click(object sender, EventArgs e)
        {
            gbHotDog.Show();
            gbburger.Hide();
            gbsandwich.Hide();
            gbsoup.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {

        }

        private void button50_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCSFESandwich_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void btnNTBBShake_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            res =  namelist.recipe(btn);
            MessageBox.Show(res.Rows.Count.ToString());
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = " ";
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnSMShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnKShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnCShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnBShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnNMShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnNOShake_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnSJuice_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            res = namelist.recipe(btn);
            MessageBox.Show(res.Rows.Count.ToString());

            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";

            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnLJuice_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnNSFMJuice_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnOJuice_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnPJuice_Click(object sender, EventArgs e)
        {
            gbtopping.Show();
            gbtopping.BringToFront();
        }

        private void btnWCTopping_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            res.Merge(namelist.recipe(btn));
            DGviwerecipe.DataSource = res;
            
            
            lblOName.Text = lblOName.Text + " with " + btn.Text;
            price = price + prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            gbtopping.Hide();
            gborder.Show();
            gborder.BringToFront();
            ;
        }

        private void btnSICTopping_Click(object sender, EventArgs e)
        {
            gbtopping.Hide();
        }

        private void btnCTopping_Click(object sender, EventArgs e)
        {
            gbtopping.Hide();
        }

        private void btnNON_Click(object sender, EventArgs e)
        {
            gbtopping.Hide();
            gborder.Show();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            if (lblprice.Text == "")
            {
                MessageBox.Show("pleace select the product");
            }
            else
            {
                lbltotal.Text = "";
                Button btn = (Button)sender;
               
                lblcount.Text = lblcount.Text + btn.Text;
                count = Convert.ToDouble(lblcount.Text);
                totalp = price * count;
                lbltotal.Text = string.Format("{0:0.00}", totalp);
            }
        }

        private void btnCSCCHSandwich_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();
        }

        private void btnODBSandwich_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();

        }

        private void btnHSPCSandwich_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = "Home Style " + btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();
        }

        private void lblNTBBShake_Click(object sender, EventArgs e)
        {

        }

        private void btnLITea_Click(object sender, EventArgs e)
        {
            lbltotal.Text = "";
            lblprice.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblOName.Text = btn.Text;
            gborder.Show();
            gborder.BringToFront();
        }

        private void btnCCoffee_Click(object sender, EventArgs e)
        {
            lblprice.Text = "";
            lbltotal.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();

        }

        private void btnNSHDog_Click(object sender, EventArgs e)
        {
            lblprice.Text = "";
            lbltotal.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();
        }

        private void btnddcburger_Click(object sender, EventArgs e)
        {
            lblprice.Text = "";
            lbltotal.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();
        }

        private void btnCCPCburger_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text;
            lblcount.Text = "";


        }

        private void btnCSSoup_Click(object sender, EventArgs e)
        {
            lblprice.Text = "";
            lbltotal.Text = "";
            Button btn = (Button)sender;
            DGviwerecipe.DataSource = namelist.recipe(btn);
            lblOName.Text = btn.Text;
            price = prices[btn.Text];
            lblprice.Text = String.Format("{0:0.00}", price);
            lblcount.Text = "";
            gborder.Show();
            gborder.BringToFront();

        }

        private void button69_Click(object sender, EventArgs e)
        {
            try
            {
                if (bill.RowCount<=0)
                {

                    MessageBox.Show("bill is empty");
                }
                else
                {
                    con = connectionManager.getconn();

                    con.Open();
                    
                    SqlCommand cmd1 = new SqlCommand("SELECT TOP 1 billID FROM bill_infor ORDER BY billID DESC", con);
                    SqlDataReader reader;
                    reader = cmd1.ExecuteReader();
                    if (reader.Read())
                    {
                        k = Convert.ToInt32(reader["billID"]);
                        k = k + 1;
                        reader.Close();

                    }
                    else
                    {
                        k = 1;
                    }
                    reader.Close();

                    string now = (DateTime.Now).ToString();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO bill_infor (billID,date,Suser,bill_total) values (@id,@date,@user,@bill)", con);
                    string u = Program.user;

                    cmd3.Parameters.AddWithValue("@date", now);

                    cmd3.Parameters.AddWithValue("@user", u);
                    cmd3.Parameters.AddWithValue("@bill", billtotal);
                    cmd3.Parameters.AddWithValue("@id", k);
                    cmd3.ExecuteNonQuery();
                    for (int i = 0; btable.Rows.Count > i; i++)
                    {
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO bItem (billID,IName,Count,price) values (@id,@name,@count,@price)", con);
                        cmd2.Parameters.AddWithValue("@name", btable.Rows[i].ItemArray.GetValue(1).ToString());
                        cmd2.Parameters.AddWithValue("@count", btable.Rows[i].ItemArray.GetValue(2).ToString());
                        cmd2.Parameters.AddWithValue("@price", btable.Rows[i].ItemArray.GetValue(3).ToString());
                        cmd2.Parameters.AddWithValue("@id", k);
                        cmd2.ExecuteNonQuery();
                    }

                    if (printPreviewDialog2.ShowDialog()== DialogResult.OK)
                    printDocument1.Print();
                  
                    MessageBox.Show("Order placed successfuly");
                    billtotal = 0;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
            lblBtotal.Text = "";
            btable.Rows.Clear();
            btable.Columns["NO"].AutoIncrementStep = -1;
            btable.Columns["NO"].AutoIncrementSeed = -1;
            btable.Columns["NO"].AutoIncrementStep = 1;
            btable.Columns["NO"].AutoIncrementSeed = 1;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            btable.Rows.Clear();
            btable.Columns["NO"].AutoIncrementStep =- 1;
            btable.Columns["NO"].AutoIncrementSeed =- 1;
            btable.Columns["NO"].AutoIncrementStep = 1;
            btable.Columns["NO"].AutoIncrementSeed = 1;
            billtotal = 0;

            lblBtotal.Text = "";
        }

        private void bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCashier.Hide();
            pnlInventory.Show();
            gbupdatestorage.Hide();
            gbCStorage.Show();
            gbhistory.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlCashier.Show();
            pnlInventory.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            logForm obj = new logForm();
            obj.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void gbburger_Enter(object sender, EventArgs e)
        {

        }

        private void lblcount_Click(object sender, EventArgs e)
        {

        }

        private void lblSMShakeP_Click(object sender, EventArgs e)
        {

        }

        private void gbsoup_Enter(object sender, EventArgs e)
        {

        }

        private void gbsandwich_Enter(object sender, EventArgs e)
        {

        }

        private void lblOName_Click(object sender, EventArgs e)
        {

        }

        private void lblprice_Click(object sender, EventArgs e)
        {

        }

        private void gbTea_Enter(object sender, EventArgs e)
        {

        }

        private void gbtopping_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblBtotal_Click(object sender, EventArgs e)
        {

        }

        private void lbltotal_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DataTable s = new DataTable();
            con = connectionManager.getconn();

            con.Open();
            SqlCommand cmd6 = new SqlCommand("select Inv_ID,Inv_Name,Inv_Qty,inv_unit from InveItems", con);
            SqlDataAdapter a = new SqlDataAdapter(cmd6);
           
            DataTable dt = new DataTable() ;
            a.Fill(dt);
            cBoxItem.DisplayMember = "Inv_Name";
            cBunit.DisplayMember = "inv_unit";
            cboxquantity.DisplayMember = "Inv_Qty";
            cboxquantity.DataSource = dt;
            cBunit.DataSource = dt;
            cBoxItem.DataSource = dt;
           
            dgstore.DataSource = dt;
           // dataGridView2.DataSource = dt;


            /* SqlCommand cmd4 = new SqlCommand(" select Inv_ID,Inv_Name,Inv_Qty from InveItems", con);
             SqlDataReader reader1 = cmd4.ExecuteReader();*/
             gbupdatestorage.Show();
             gbupdatestorage.BringToFront();
             /* s.Load(reader1);
              dgstore.DataSource = s;*/
        }

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            try
            {
                con = connectionManager.getconn();
                con.Open();
                string now = (DateTime.Now).ToString();
                SqlCommand cmd5 = new SqlCommand("INSERT INTO InveItems (Inv_Name,Inv_Qty,Inv_AddDate,inv_unit) values (@name,@count,@date,@unit)", con);
                double s = Convert.ToDouble(cboxquantity.Text) * Convert.ToDouble(tbox.Text);
                cmd5.Parameters.AddWithValue("@name", cBoxItem.Text);
                cmd5.Parameters.AddWithValue("@count", s.ToString());
                cmd5.Parameters.AddWithValue("@date", now);
                cmd5.Parameters.AddWithValue("@unit", cBunit.Text);
                cmd5.ExecuteNonQuery();
                SqlCommand cmd6 = new SqlCommand("select Inv_ID,Inv_Name,Inv_Qty,inv_unit from InveItems", con);
                SqlDataAdapter a = new SqlDataAdapter(cmd6);
                DataTable dt = new DataTable();
                a.Fill(dt);
                cBoxItem.DisplayMember = "Inv_Name";
                cBoxItem.DataSource = dt;
                dgstore.DataSource = dt;
                MessageBox.Show("item Add successfully");
              
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCStorage_Click(object sender, EventArgs e)
        {
            DataTable s = new DataTable();
            con = connectionManager.getconn();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("select Inv_ID,Inv_Name,Inv_Qty from InveItems", con);
            SqlDataReader reader1 = cmd4.ExecuteReader();
            gbupdatestorage.Show();
            gbupdatestorage.BringToFront();
            s.Load(reader1);
            dgcurrent.DataSource = s;
            gbupdatestorage.Show();
            gbupdatestorage.BringToFront();
            s.Load(reader1);
            dgstore.DataSource = s;
            gbCStorage.Show();
            gbupdatestorage.Hide();
            dgstore.Refresh();
            gbCStorage.BringToFront();

        }

        private void dgcurrent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgstore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try {
                SqlConnection con;
                con = connectionManager.getconn();
                con.Open();
                DateTime now = DateTime.Now;
                SqlCommand cmd3 = new SqlCommand("update InveItems set Inv_Qty=@nqu,Inv_AddDate=@date where Inv_Name = @name ", con);
                cmd3.Parameters.AddWithValue("@name", cBoxItem.Text);
                cmd3.Parameters.AddWithValue("@date", now.ToString());
                double to = Convert.ToDouble(cboxquantity.Text) * Convert.ToDouble(tbox.Text);
                
                cmd3.Parameters.AddWithValue("@nqu",to );
                cmd3.ExecuteNonQuery();
                dgstore.Refresh();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cBunit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSHistry_Click(object sender, EventArgs e)
        {
            gbupdatestorage.Hide();
            gbCStorage.Hide();
            gbhistory.Show();
            gbhistory.BringToFront();

            DataTable s = new DataTable();
            con = connectionManager.getconn();

            con.Open();
            SqlCommand cmd4 = new SqlCommand("select * from Store_log ORDER BY NO DESC", con);
            SqlDataReader reader1 = cmd4.ExecuteReader();
            s.Load(reader1);
            dghistory.DataSource = s;
        }

        private void pnlInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gborder_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lblOName.Text = "";
            lblprice.Text = "";
            lbltotal.Text = "";
            lblcount.Text = "";
            gborder.Hide();
            gbtopping.Hide();
        }

        private void button2_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog2_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTime now = DateTime.Now;
            e.Graphics.DrawString("----------------Vcafe-------------------", new Font("Cambria", 25, FontStyle.Bold),Brushes.Red,new Point(200,40));
            e.Graphics.DrawString( now.ToString() + "                       "+"Bill no "+k.ToString(), new Font("Cambria", 12, FontStyle.Bold), Brushes.Red, new Point(200,80));
            e.Graphics.DrawString("Cashier      " + Program.user, new Font("Cambria", 14, FontStyle.Bold), Brushes.Red, new Point(200, 120));
            e.Graphics.DrawString("------------------------------------------", new Font("Cambria", 25, FontStyle.Bold), Brushes.Red, new Point(200, 120));
            int r = 150;
            for (int i = 0; btable.Rows.Count > i; i++)
            {
                e.Graphics.DrawString(btable.Rows[i].ItemArray.GetValue(1).ToString(), new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(250, r));
                e.Graphics.DrawString(btable.Rows[i].ItemArray.GetValue(2).ToString(), new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(500, r+30));
                e.Graphics.DrawString(btable.Rows[i].ItemArray.GetValue(3).ToString(), new Font("Cambria", 12, FontStyle.Bold), Brushes.Black, new Point(600, r+30));
                r += 60;
            }
            e.Graphics.DrawString("------------------------------------------", new Font("Cambria", 25, FontStyle.Bold), Brushes.Red, new Point(200, r+30));
            e.Graphics.DrawString("TOTAL   "+lblBtotal.Text, new Font("Cambria", 25, FontStyle.Bold), Brushes.Red, new Point(200, r + 70));
            e.Graphics.DrawString("------------------------------------------", new Font("Cambria", 25, FontStyle.Bold), Brushes.Red, new Point(200, r + 110));
            e.Graphics.DrawString("            Thank you, Come again ! ", new Font("Cambria", 20, FontStyle.Bold), Brushes.Black, new Point(200, r + 150));
            e.Graphics.DrawString("------------------------------------------", new Font("Cambria", 25, FontStyle.Bold), Brushes.Red, new Point(200, r + 170));



        }

        private void btnrowdelate_Click(object sender, EventArgs e)
        {
            int rowIndex = bill.CurrentCell.RowIndex;
            bill.Rows.RemoveAt(rowIndex);
        }

        private void tbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Width, this.dgcurrent.Height);
            dgcurrent.DrawToBitmap(bm, new Rectangle(0, 0, this.dgcurrent.Width, this.dgcurrent.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnCStore_Click(object sender, EventArgs e)
        {
            int height = dgcurrent.Height;
            dgcurrent.Height = dgcurrent.RowCount * dgcurrent.RowTemplate.Height;
            Bitmap bitmap = new Bitmap(this.dgcurrent.Width, this.dgcurrent.Height);
            dgcurrent.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dgcurrent.Width, this.dgcurrent.Height));
            dgcurrent.Height = height;

            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();

        }

        private void gbhistory_Enter(object sender, EventArgs e)
        {

        }

        private void btnToday_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            int height = dghistory.Height;
            dghistory.Height = dghistory.RowCount * dghistory.RowTemplate.Height;
            Bitmap bitmap = new Bitmap(this.dghistory.Width, this.dghistory.Height);
            dghistory.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dghistory.Width, this.dghistory.Height));
            dghistory.Height = height;

            printPreviewDialog3.Document = printDocument3;
            printPreviewDialog3.PrintPreviewControl.Zoom = 1;
            printPreviewDialog3.ShowDialog();


        }

        private void printDocument3_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.Width, this.dghistory.Height);
            dghistory.DrawToBitmap(bm, new Rectangle(0, 0, this.dghistory.Width, this.dghistory.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
