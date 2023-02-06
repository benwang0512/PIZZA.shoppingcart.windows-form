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
using System.Collections;

namespace 期末最終版
{
    public partial class Form產品 : Form
    {
        string strMyDBConnectionString = "";
        List<string> list產品 = new List<string>();
        List<int> list價格 = new List<int>();
        List<int> listId = new List<int>();
        int list單價價格 = 0;

        public Form產品()
        {
            InitializeComponent();
        }

        private void Form產品_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pizza";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();          
            讀取資料庫();
            showListView圖片模式();
            lbl登入狀態.Text = "登入狀態:"+GlobalVar.會員名稱;


        }
        void 讀取資料庫()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            Console.WriteLine(GlobalVar.listName);
            string strSQL = " select* from pizza菜單 where 產品類別 = " + "'"+ GlobalVar.listName + "'"+"and 是否供應 = 1";
            //" select* from pizza菜單 where 產品類別 = " + GlobalVar.listName; 
            //"select * from pizza菜單 where 產品類別= '甜點飲料'";
            SqlCommand cmd = new SqlCommand(strSQL, con);         
            SqlDataReader reader = cmd.ExecuteReader();
            //cmd.Parameters.AddWithValue("@a", GlobalVar.listName);

            string image_dir = @"images\";//圖檔路徑 全域變數比較好
            string image_name = "";//圖檔名稱 全域變數比較好
            //int i = 0;

            while (reader.Read())
            {
                listId.Add((int)reader["ID"]);
                list產品.Add(reader["商品名稱"].ToString());
                list價格.Add((int)reader["商品價錢"]);
                image_name = reader["image"].ToString();
                imageList商品圖檔.Images.Add(Image.FromFile(image_dir + image_name));

                //i++;
            }
            //Console.WriteLine(listId[0]);
            //Console.WriteLine("讀取{0}筆資料", i);
            reader.Close();
            con.Close();
        }
        private void btn圖片模式_Click(object sender, EventArgs e)
        {
            showListView圖片模式();
        }

        void showListView圖片模式()
        {
            listView商品展示.Clear();
            listView商品展示.View = View.LargeIcon;//圖片顯示模式4種 LargeIcon,SmallIcon,List,Tile;
            imageList商品圖檔.ImageSize = new Size(120, 120);
            listView商品展示.LargeImageList = imageList商品圖檔;//大圖LargeIcon, Tile
            listView商品展示.SmallImageList = imageList商品圖檔;//小圖smallicon, List

            for (int i = 0; i < imageList商品圖檔.Images.Count; i++)
            {
                ListViewItem itme = new ListViewItem();
                itme.ImageIndex = i;//索引質對應
                itme.Font = new Font("微軟正黑體", 14, FontStyle.Regular);
                itme.Text = list產品[i] + " " + list價格[i] + "元";
                itme.Tag = listId[i];
                listView商品展示.Items.Add(itme);
            }

        }

        private void btn列表模式_Click(object sender, EventArgs e)
        {
            showListView列表模式();
        }
        void showListView列表模式()
        {
            listView商品展示.Clear();
            listView商品展示.LargeImageList = null;
            listView商品展示.SmallImageList = null;
            listView商品展示.View = View.Details;
            listView商品展示.Columns.Add("商品名稱", 200);
            listView商品展示.Columns.Add("商品價格", 200);
            listView商品展示.FullRowSelect = true; //選某一列直接反白
            listView商品展示.GridLines = true;//顯示格線

            for (int i = 0; i < listId.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.Font = new Font("微軟正黑體", 20, FontStyle.Regular);
                item.Text = list產品[i];//第二欄
                item.SubItems.Add(list價格[i].ToString());//第三欄
                item.Tag = listId[i];

                listView商品展示.Items.Add(item);              
            }
        }

        void 所選單價價格()
        {
           
        }

        private void btn加入購物車_Click(object sender, EventArgs e)
        {
            GlobalVar.商品ID.Add(GlobalVar.所選id);
            if (GlobalVar.所選id > 0 && GlobalVar.listName == "主餐")
            {
                餐點配料選擇 myFormDetail = new 餐點配料選擇();
                //Console.WriteLine(GlobalVar.productname);
                //Console.WriteLine(GlobalVar.productprice);
                myFormDetail.productID = GlobalVar.所選id;
                myFormDetail.ShowDialog();        
            }
            else if (GlobalVar.所選id > 0)
            {
                //Console.WriteLine(GlobalVar.productname);
                //Console.WriteLine(GlobalVar.productprice);
                ArrayList 品項訂購資訊 = new ArrayList();
                品項訂購資訊.Add(GlobalVar.productname);
                品項訂購資訊.Add(GlobalVar.productprice);
                品項訂購資訊.Add("");
                品項訂購資訊.Add("");
                GlobalVar.list訂購品項資訊列表.Add(品項訂購資訊);
                //Console.WriteLine(GlobalVar.productprice);
                GlobalVar.所選id = 0;
                MessageBox.Show("成功加入購物車");
            }
                       
        }

        private void listView商品展示_ItemActivate(object sender, EventArgs e)
        {
            //新增商品表單 myFormDetail = new 新增商品表單();           
            //myFormDetail.ShowDialog();
            GlobalVar.所選id = Convert.ToInt32(listView商品展示.SelectedItems[0].Tag);         
            if (GlobalVar.所選id > 0)
            {
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = "select * from pizza菜單 where ID = @SearchID ";
                //" select* from pizza菜單 where 產品類別 = " + "'" + GlobalVar.listName + "'";
                //"select * from " + GlobalVar.listName + " where ID = @SearchID "
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", GlobalVar.所選id);             

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    list單價價格 = ((int)reader["商品價錢"]);
                    GlobalVar.productname = ((string)reader["商品名稱"]);
                    GlobalVar.productprice = ((int)reader["商品價錢"]);
                    GlobalVar.上架日期 = ((DateTime)reader["上架日期"]);
                }
                reader.Close();
                con.Close();
            }
            lbl單價.Text = Convert.ToString(list單價價格)+"元";         
        }      

        private void btn重新載入_Click(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalVar.listName);
            Console.WriteLine(GlobalVar.所選id);
        }
    }
}
