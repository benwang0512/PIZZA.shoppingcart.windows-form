using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 期末最終版
{
    public partial class 新增商品表單 : Form
    {
        
        string strMyDBConnectionString = "";
        string image_dir = @"images\";
        string image_name = "";
        bool is已修改圖檔 = false;
        List<string> 商品類別 = new List<string>();
        string 所選品項;       

        public 新增商品表單()
        {
            InitializeComponent();
        }

        private void 新增商品表單_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pizza";
            scsb.IntegratedSecurity = true;
            strMyDBConnectionString = scsb.ToString();

            if (GlobalVar.所選id == 0)
            {
                groupBox新增商品資訊.Visible = true;
                groupBox修改商品資訊.Visible = false;
            }
            else
            {
                groupBox新增商品資訊.Visible = false;
                groupBox修改商品資訊.Visible = true;
                顯示商品細項資訊();
            }
            商品類別.Add("配餐");
            商品類別.Add("主餐");
            商品類別.Add("甜點飲料");
            for (int i = 0; i < 商品類別.Count; i++)
            {
                string strtime = 商品類別[i];
                comboBox商品類別.Items.Add(strtime);
            }
        }
        void 顯示商品細項資訊()
        {
            SqlConnection con = new SqlConnection(strMyDBConnectionString);
            con.Open();
            string strSQL = "select * from pizza菜單 where id = @SearchId;";           
            Console.WriteLine(strSQL);
            SqlCommand cmd = new SqlCommand(strSQL, con);

            cmd.Parameters.AddWithValue("@SearchId", GlobalVar.所選id);
            SqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            while (reader.Read())
            {
                lblid.Text = reader["ID"].ToString();
                txt商品名稱.Text = reader["商品名稱"].ToString();
                txt商品價格.Text = reader["商品價錢"].ToString();
                chktrue.Checked = Convert.ToBoolean(reader["是否供應"]);
                image_name = reader["image"].ToString();
                pictureBox商品圖檔.Image = Image.FromFile(image_dir + image_name);
                i++;
            }
            reader.Close();
            con.Close();
        }

        private void btn選取修改商品照片_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "檔案類型(*.jpg,*jeg,*png)|*.jpeg;*.jpg;*.png";
            DialogResult R = f.ShowDialog();
            if (R == DialogResult.OK)
            {
                pictureBox商品圖檔.Image = Image.FromFile(f.FileName);
                string fileExt = System.IO.Path.GetExtension(f.SafeFileName);
                Random myRand = new Random();
                image_name = DateTime.Now.ToString("yyyMMddHHmmss") + myRand.Next(1000, 10000).ToString() + fileExt;
                is已修改圖檔 = true;
                Console.WriteLine(image_name);
            }
        }

        private void btn儲存修改_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") &&  (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                    //存檔
                }         
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();           
                string strSQL = " update pizza菜單  set 商品名稱=@NewName, 商品價錢=@NewPrice, 是否供應=@NewTrueFalse, image=@NewImageName where ID = @SearchId;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchId", lblid.Text);             
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewTrueFalse", chktrue.Checked);
                cmd.Parameters.AddWithValue("@NewImageName", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }        
        }

        private void btn清空欄位_Click(object sender, EventArgs e)
        {           
            //Console.WriteLine((comboBox商品類別.Items[comboBox商品類別.SelectedIndex]));
            lblid.Text = "";
            txt商品名稱.Clear();
            txt商品價格.Clear();
            pictureBox商品圖檔.Image = null;
        }

        private void btn儲存商品_Click(object sender, EventArgs e)
        {
            if ((txt商品價格.Text != "") && (txt商品名稱.Text != "") && (pictureBox商品圖檔.Image != null))
            {
                if (is已修改圖檔)
                {
                    pictureBox商品圖檔.Image.Save(image_dir + image_name);
                    is已修改圖檔 = false;
                    //存檔
                }
                SqlConnection con = new SqlConnection(strMyDBConnectionString);
                con.Open();
                string strSQL = " insert into pizza菜單 values (@NewName, @NewPrice, @NewDay, 1, @NewCategory, @NewImageName);";                       
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
                int intPrice = 0;
                Int32.TryParse(txt商品價格.Text, out intPrice);
                cmd.Parameters.AddWithValue("@NewPrice", intPrice);
                cmd.Parameters.AddWithValue("@NewDay", DateTime.Now);
                cmd.Parameters.AddWithValue("@NewCategory", comboBox商品類別.Items[comboBox商品類別.SelectedIndex]);
                cmd.Parameters.AddWithValue("@NewImageName", image_name);
                int rows = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");             
            }
            else
            {
                MessageBox.Show("所有欄位必填");
            }
            
        }

        //private void btn刪除產品_Click(object sender, EventArgs e)
        //{
        //    SqlConnection con = new SqlConnection(strMyDBConnectionString);
        //    con.Open();
        //    string strSQL = " insert into " + GlobalVar.listName + " values (@NewName, @NewPrice, @NewDay, 1, @NewImageName);";
        //    SqlCommand cmd = new SqlCommand(strSQL, con);
        //    cmd.Parameters.AddWithValue("@NewName", txt商品名稱.Text);
        //    int intPrice = 0;
        //    Int32.TryParse(txt商品價格.Text, out intPrice);
        //    cmd.Parameters.AddWithValue("@NewPrice", intPrice);
        //    cmd.Parameters.AddWithValue("@NewDay", DateTime.Now);
        //    cmd.Parameters.AddWithValue("@NewImageName", image_name);
        //    int rows = cmd.ExecuteNonQuery();
        //    con.Close();
        //    MessageBox.Show("資料儲存成功, 影響" + rows + "筆資料");
        //}
    }
}


