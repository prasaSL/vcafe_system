using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
namespace cafe_system
{
    public partial class workarsForm : Form
    {
        public int count = 0;
        public int price = 0;
        public int index = 0;

        SqlConnection con;
        public workarsForm()
        {
            InitializeComponent();
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
           try{
            foreach (KeyValuePair<string, string> i in namelist.itemlist)
            {
                string price1 , price;
                SqlCommand cmd = new SqlCommand("select * from Item where itemName = @Iname", con);
                cmd.Parameters.AddWithValue("@Iname",i.Value);
                  SqlDataReader reader;
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //price1 = reader["price"].ToString();
                price = String.Format("{0:0.00}", reader["price"]);
            Control[] a =   this.Controls.Find(i.Key,true);
            a[0].Text = price;
            reader.Close();
            }
            }
           }
            catch(Exception ex){
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
        }
        public void lordmainpanal(object Form) {
          
        
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
            if (lblcount.Text == "") {
                MessageBox.Show("count can't be empty");
            }
            string item = lblOName.Text;
            int count = Convert.ToInt32(lblcount.Text);
            index = index + 1;
            int total = price * count;
            
            string[] row = new string[] { item, count.ToString(), total.ToString()};
            bill.Rows.Add(row);
            lblOName.Text = "";
            lblcount.Text = "";
            lblprice.Text = "";
            lbltotal.Text = "";

        }

        private void button18_Click(object sender, EventArgs e)
        {
            lblOName.Text = "";
            lblcount.Text = "";
            lblprice.Text = "";

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
            Button btn = (Button)sender;
            lblOName.Text = btn.Text;
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
            Button btn = (Button)sender;
            lblOName.Text = btn.Text + " juice";
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
            gbtopping.BringToFront();       }

        private void btnWCTopping_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = lblOName.Text + " with " + btn.Text + " topping";
            gbtopping.Hide();

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
        }

        private void c1_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            lblcount.Text = lblcount.Text + btn.Text;
        }

        private void btnCSCCHSandwich_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            lblOName.Text = "Club Sandwich " + btn.Text;
            lblcount.Text = "";
        }

        private void btnODBSandwich_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text + " Sandwich";
            lblcount.Text = "";

        }

        private void btnHSPCSandwich_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = "Home Style " +btn.Text + " Sandwich";
            lblcount.Text = "";

        }

        private void lblNTBBShake_Click(object sender, EventArgs e)
        {

        }

        private void btnLITea_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text;
            
        }

        private void btnCCoffee_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text + " Coffee";
            lblcount.Text = "";

        }

        private void btnNSHDog_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text + " Hot Dog";
            lblcount.Text = "";

        }

        private void btnddcburger_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text + "Burger";
            lblcount.Text = "";
        }

        private void btnCCPCburger_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text ;
            lblcount.Text = "";


        }

        private void btnCSSoup_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            lblOName.Text = btn.Text +" Soup";
            lblcount.Text = "";


        }

        private void button69_Click(object sender, EventArgs e)
        {
            bill.Rows.Clear();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            bill.Rows.Clear();
        }

        private void bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlCashier.Hide();
            pnlInventory.Show();
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
    }
}
