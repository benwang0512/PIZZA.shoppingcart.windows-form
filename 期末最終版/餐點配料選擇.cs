using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 期末最終版
{
    public partial class 餐點配料選擇 : Form
    {
        string strMyDBConnectionString = "";
        public int productID = 0;
        string image_dir = @"images\";
        string image_name = "";
        string price單價 = "";
        Dictionary<string, int> list餅皮 = new Dictionary<string, int>();
        Dictionary<string, int> list起司 = new Dictionary<string, int>();
        int 餅皮價格;
        int 起司價格;
        int 所選品項總價;

        public 餐點配料選擇()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void 餐點配料選擇_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pizza";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();
            //Console.WriteLine(productID);
            //Console.WriteLine(GlobalVar.listName);
            讀取資料庫();
            餅皮產品名稱();
            起司產品名稱();
        }

        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from pizza菜單 where ID = @SearchID ";
            
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@SearchId", productID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                price單價 = reader["商品價錢"].ToString();

                image_name = reader["image"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                
            }
            lbl商品總價.Text = price單價;

            reader.Close();
            con.Close();        
        }

        void 餅皮產品名稱()//餅皮產品
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from pizza餅皮;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string p品項 = reader["商品名稱"].ToString();
                string p價錢 = reader["商品價錢"].ToString();
                strMsg += string.Format("{0} {1}元\n", p品項, p價錢);
                comboBox餅皮.Items.Add(strMsg);
                list餅皮.Add(p品項, Convert.ToInt32(p價錢));
                       
            }
            comboBox餅皮.SelectedIndex = 0;
            reader.Close();
            con.Close();
        }

        void 起司產品名稱()//起司產品
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from pizza起司;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string strMsg = "";
                string p品項 = reader["商品名稱"].ToString();
                string p價錢 = reader["商品價錢"].ToString();
                strMsg += string.Format("{0} {1}元\n", p品項, p價錢);
                comboBox起司.Items.Add(strMsg);
                list起司.Add(p品項, Convert.ToInt32(p價錢));
            }
            comboBox起司.SelectedIndex = 0;                  
            reader.Close();
            con.Close();
        }

        void 計算所選品項總價()
        {
            所選品項總價 = Convert.ToInt32(price單價) + 餅皮價格 + 起司價格;
            lbl商品總價.Text = String.Format("{0}元", 所選品項總價);
        }
      
        private void comboBox餅皮_SelectedIndexChanged(object sender, EventArgs e)
        {
            餅皮價格 = (list餅皮.ElementAt(comboBox餅皮.SelectedIndex).Value);
            GlobalVar.餅皮名稱= (list餅皮.ElementAt(comboBox餅皮.SelectedIndex).Key);
            計算所選品項總價();
        }

        private void comboBox起司_SelectedIndexChanged(object sender, EventArgs e)
        {          
            起司價格 = (list起司.ElementAt(comboBox起司.SelectedIndex).Value);
            GlobalVar.起司名稱 = (list起司.ElementAt(comboBox起司.SelectedIndex).Key);
            計算所選品項總價();
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            ArrayList 品項訂購資訊 = new ArrayList();
            品項訂購資訊.Add(GlobalVar.productname);
            品項訂購資訊.Add(所選品項總價);
            品項訂購資訊.Add(GlobalVar.餅皮名稱);
            品項訂購資訊.Add(GlobalVar.起司名稱);
            GlobalVar.list訂購品項資訊列表.Add(品項訂購資訊);
            GlobalVar.所選id = 0;
            MessageBox.Show("成功加入購物");
            this.Close();
            //Console.WriteLine(GlobalVar.productname);
            //Console.WriteLine(GlobalVar.productprice);
            //Console.WriteLine(GlobalVar.餅皮名稱);
            //Console.WriteLine(GlobalVar.起司名稱);
        }
    }
}
