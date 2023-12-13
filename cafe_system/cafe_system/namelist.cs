using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe_system
{
    public class namelist
    {
       public static DataTable rlis = new DataTable();
         public static Dictionary<string, string> itemlist = new Dictionary<string, string>() { { "lblddcburgerP", "Double Decker Chiken burger" }, { "lblVburgerP", "Veggie burger" },
        { "lblCCPCburgerP", "Crispy Chiken Burger with Chips burger" }, { "lblBBurgerP", "Beef Burger burger" }, { "lblCSSoupP", "Chiken and Sweetcorn Soup" }, 
        { "lblCCSoupP", "Carrot and Coriander Soup" }, { "lblCMSoupP", "Creamy Mashroom Soup" }, { "lblSJuiceP", "Strowaberry Juice" }, { "lblLJuiceP", "Lime juice" }, 
        { "lblWJuiceP", "Watermelon juice" }, { "lblSFMJuiceP", "Special Fruit Mocktail" }, { "lblOJuiceP", "Orange juice" }, { "lblPJuiceP", "Pineple juice" }, 
        { "lblCSCCHSandwichP", "Club Sandwich with Chicken" }, { "lblCSFESandwichP", "Club Sandwich with Egg" }, { "lblODBSandwichP", "Open Dijon Beef" }, 
        { "lblHSPCSandwichP", "Polos and Cheese sandwich" }, { "lblHSCCSandwichP", "Crumb Chiken sandwich" }, { "lblHSPESandwichP", "Polsambal and Eggs sandwich" },
        { "lblNTBBShakeP", "triple Berry Blend shake" }, { "lblSMShakeP", "Strawberry Milk Shake" }, { "lblKShakeP", "Kiwi Shake" }, { "lblCShakeP", "Chocolate Shake" },
        { "lblDFShakeP", "Dark Fudge Shake" }, { "lblBShakeP", "Bluberry Shake" }, { "lblNMShakeP", "Nutella MilkShake" }, { "lblNOShakeP", "Nutella Oreo Shake" },
        { "lblLITeaP", "Black Tea" }, { "lblCITeaP", "White Tea" }, { "lblPUTeaP", "Herbal Tea" }, { "lblGTeaP", "Green Tea" }, { "lblSITeaP", "Oolong Tea" }, 
        { "lblRTeaP", "Rooibos Tea" }, { "lblCCoffeeP", "Cappucino" }, { "lblACoffeP", "Americano" }, { "lblCLCoffeP", "Cafe Latte" }, { "lblMLCoffeeP", "Iced Cofee" }, 
        { "lblNSHDogP", "Special hot dog" }, { "lblCHDogP", "Chili Chicken hot dog" }, { "lblWCToppingP", "Whipped Cream topping" },
        { "lblSICToppingP", "Scoop Of Ice Cream topping" }, { "lblCToppingP", "Chocolate topping" }, { "lblCaLCoffeeP", "Flat White" }, { "lblCBLCoffeeP", "Espresso" } };

        

        public static DataTable recipe(Button btn) {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ingredient", typeof(string));
            dt.Columns.Add("amount", typeof(string));
            SqlConnection con;
            con = connectionManager.getconn();
            int RIDi =0;
            try
            {

                con.Open();
                
                SqlCommand cmd = new SqlCommand("select RID from Item where itemName = @Iname",con);
                cmd.Parameters.AddWithValue("@Iname", btn.Text);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    RIDi = Convert.ToInt32(reader["RID"]);


                }
                reader.Close();
              
                string cmd1 = "select Ingredient,amountString  from recipes where RID = "+ RIDi;

                SqlDataAdapter adupter = new SqlDataAdapter(cmd1, con);
                using (SqlDataAdapter adapter = adupter)
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dt = ds.Tables[0];

                }
                string cmd2 = "select Ingredient,amount  from recipes where RID = " + RIDi;
                SqlDataAdapter adupter1 = new SqlDataAdapter(cmd2, con);
                using (SqlDataAdapter adapter1 = adupter1)
                {
                    DataSet ds = new DataSet();
                    adapter1.Fill(ds);
                    rlis = ds.Tables[0];

                }

                con.Close();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
                return dt;



        }
       public static Dictionary<string, double> update = new Dictionary<string, double>();
        public static bool stor(double count) {
            SqlConnection con;
            bool run = false;
            con = connectionManager.getconn();
          
            bool go = false;
      
         
            try
            {

                con.Open();
                for (int i = 0; rlis.Rows.Count > i; i++)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT  Inv_Qty FROM InveItems where Inv_Name = @name", con);
                   
                    cmd2.Parameters.AddWithValue("@name", rlis.Rows[i].ItemArray.GetValue(0).ToString());
                    SqlDataReader reader2;
                    reader2 = cmd2.ExecuteReader();
                     double baln=0;
                    
                    double svlae = 0;
                    reader2.Read();
                    svlae = Convert.ToDouble(reader2["Inv_Qty"]);
                       
                        reader2.Close();
                    
                    double rvlae = Convert.ToDouble(rlis.Rows[i].ItemArray.GetValue(1).ToString());
                
                    baln = svlae - (rvlae * count);
                   
                    if (baln <= 0)
                    {
                        MessageBox.Show("not enough Ingredient...");
                        break;
                      

                    }
                    else {
                        update.Add(rlis.Rows[i].ItemArray.GetValue(0).ToString(), baln);
                        go = true;
                    }
                   
                }
                if (go == true)
                {
                    foreach (KeyValuePair<string, double> k in update)
                    {
                        DateTime now = DateTime.Now;
                        try
                        {
                            SqlCommand cmd3 = new SqlCommand("update InveItems set Inv_Qty=@nqu where Inv_Name = @name ", con);
                            cmd3.Parameters.AddWithValue("@nqu", k.Value);
                            cmd3.Parameters.AddWithValue("@name", k.Key);
                            cmd3.ExecuteNonQuery();
                            SqlCommand cmd5 = new SqlCommand("select amount from recipes where Ingredient = @Iname", con);
                            cmd5.Parameters.AddWithValue("@Iname", k.Key);

                            SqlDataReader reader4;
                            reader4 = cmd5.ExecuteReader();
                            reader4.Read();
                            double c = Convert.ToDouble(reader4["amount"]);
                            reader4.Close();
                            SqlCommand cmd4 = new SqlCommand("INSERT INTO  Store_log values (@ing, 'for seles products',@d,@amo) ", con);
                            cmd4.Parameters.AddWithValue("@ing", k.Key);

                            cmd4.Parameters.AddWithValue("@d", now.ToString());
                            cmd4.Parameters.AddWithValue("@amo", 0 -c);
                            
                            cmd4.ExecuteNonQuery();
                            
                            run = true;
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.ToString());
                        }
                        update = new  Dictionary<string, double>();
                    }
                }
                



            }
            catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
            return run;
        }
       

    }
}
