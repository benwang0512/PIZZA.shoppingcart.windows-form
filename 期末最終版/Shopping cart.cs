using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 期末最終版
{
    public partial class Shopping_cart : Form
    {
        string 自取外送 ;
        int 原始訂單總價 = 0;
        double 進入SQL的價錢;
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        List<string> list訂單時間 = new List<string>();
        List<string> 商品名稱 = new List<string>();
        List<int> 商品單價 = new List<int>();
        List<string> 商品起司 = new List<string>();
        List<string> 商品餅皮 = new List<string>();
        string 取餐日期 = DateTime.Now.ToShortDateString();
        string 取餐時間;
        int 訂單編號;
        double 外送加價;
        public Shopping_cart()
        {
            InitializeComponent();
        }

        private void Shopping_cart_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //代表伺服器名稱
                                    //.點本機的意思 @不處理特殊符號
            scsb.InitialCatalog = "pizza";//database 資料庫名稱
            scsb.IntegratedSecurity = true;//資料庫驗證
            strDBconnectionString = scsb.ToString();//可以設定成全域變數 轉成字串
            list訂單時間.Add("11:30");
            list訂單時間.Add("12:00");
            list訂單時間.Add("12:30");
            list訂單時間.Add("13:00");
            list訂單時間.Add("13:30");
            list訂單時間.Add("14:00");
            list訂單時間.Add("14:30");
            list訂單時間.Add("15:00");
            list訂單時間.Add("15:30");
            list訂單時間.Add("16:00");
            list訂單時間.Add("16:30");
            list訂單時間.Add("17:00");
            list訂單時間.Add("17:30");
            list訂單時間.Add("18:00");
            list訂單時間.Add("18:30");
            list訂單時間.Add("19:00");
            list訂單時間.Add("19:30");
            list訂單時間.Add("20:00");
            list訂單時間.Add("20:30");
            list訂單時間.Add("21:00");
            list訂單時間.Add("21:30");            
            for (int i = 0; i < list訂單時間.Count; i++)
            {
                string strtime = list訂單時間[i] ;
                comboBox時間.Items.Add(strtime);
            }          
            comboBox時間.SelectedIndex = 0;
            foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
            {            
                string 品項 = (string)訂購品項[0];
                int 單價 = (int)訂購品項[1];
                string 餅皮 = (string)訂購品項[2];
                string 起司 = (string)訂購品項[3];


                商品名稱.Add (品項);
                商品單價.Add(單價);
                商品起司.Add(餅皮);
                商品餅皮.Add(起司);        

                string str品項資訊 = string.Format("{0} {1}元 {2} {3}", 品項, 單價, 餅皮, 起司);
                listBox訂購單資訊.Items.Add(str品項資訊);              
            }  
            radio自取.Checked = true;
            text外送地址.Enabled = false;
            自取外送 = "自取";
            計算訂單總價();
        }
        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (listBox訂購單資訊.SelectedIndex > -1)
            {
                int selIndex = listBox訂購單資訊.SelectedIndex;

                GlobalVar.list訂購品項資訊列表.RemoveAt(selIndex);
                listBox訂購單資訊.Items.RemoveAt(selIndex);
                商品名稱.RemoveAt(selIndex);
                商品單價.RemoveAt(selIndex);
                商品起司.RemoveAt(selIndex);
                商品餅皮.RemoveAt(selIndex);

                移除計算訂單總價();
            }
            else
            {
                MessageBox.Show("請選擇移除品項");
            }

            Console.WriteLine(自取外送);
            Console.WriteLine(GlobalVar.會員ID);
           

        }
        private void btn移除所有品項_Click(object sender, EventArgs e)
        {
            listBox訂購單資訊.Items.Clear();
            GlobalVar.list訂購品項資訊列表.Clear();      
            計算訂單總價();
            //成功失敗();
        }

        void 計算訂單總價()
        {
            if (GlobalVar.titlID>=1)
            {
                int 訂單總價 = 0;
                foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
                {
                    string 品項 = (string)訂購品項[0];
                    int 單價 = (int)訂購品項[1];
                    string 餅皮 = (string)訂購品項[2];
                    string 起司 = (string)訂購品項[3];
                    訂單總價 += 單價;
                }
                外送加價 = Math.Ceiling(訂單總價 * 0.9);
                原始訂單總價 = 訂單總價;
                進入SQL的價錢 = 外送加價;
                lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 訂單總價, Math.Ceiling(訂單總價 * 0.9));
            }
            else
            {
                int 訂單總價 = 0;
                foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
                {
                    string 品項 = (string)訂購品項[0];
                    int 單價 = (int)訂購品項[1];
                    string 餅皮 = (string)訂購品項[2];
                    string 起司 = (string)訂購品項[3];
                    訂單總價 += 單價;
                }
                外送加價 = 訂單總價 ;
                原始訂單總價 = 訂單總價;
                進入SQL的價錢 = 訂單總價;
                lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);             
            }
           
        }

        void 移除計算訂單總價()
        {
            if (GlobalVar.titlID >= 1)
            {             
                    int 訂單總價 = 0;
                    foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
                    {
                        string 品項 = (string)訂購品項[0];
                        int 單價 = (int)訂購品項[1];
                        string 餅皮 = (string)訂購品項[2];
                        string 起司 = (string)訂購品項[3];
                        訂單總價 += 單價;
                    }
                    外送加價 = Math.Ceiling(訂單總價 * 0.9);
                    原始訂單總價 = 訂單總價;
                    進入SQL的價錢 = 外送加價;               
                if (原始訂單總價 >= 1000 && radio外送.Checked == true)
                {              
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 訂單總價, Math.Ceiling((訂單總價 * 0.9)));
                    
                    進入SQL的價錢 = Convert.ToInt32(訂單總價 * 0.9);
                    
                }
                else if(radio外送.Checked == true)
                {                 
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 訂單總價, Math.Ceiling((訂單總價 * 0.9) + 39));
                    進入SQL的價錢 = Convert.ToInt32(訂單總價 * 0.9) + 39;
                }
                else
                {
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 訂單總價, Math.Ceiling((訂單總價 * 0.9)));
                    進入SQL的價錢 = Convert.ToInt32(訂單總價 * 0.9);
                }
               
            }
            else
            {               
                    int 訂單總價 = 0;
                    foreach (ArrayList 訂購品項 in GlobalVar.list訂購品項資訊列表)
                    {
                        string 品項 = (string)訂購品項[0];
                        int 單價 = (int)訂購品項[1];
                        string 餅皮 = (string)訂購品項[2];
                        string 起司 = (string)訂購品項[3];
                        訂單總價 += 單價;
                    }
                    外送加價 = 訂單總價;
                    原始訂單總價 = 訂單總價;
                    進入SQL的價錢 = 訂單總價;                                
                if (原始訂單總價 >= 1000 && radio外送.Checked == true)
                {
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);
                    進入SQL的價錢 = Convert.ToInt32(訂單總價);
                }
                else if (radio外送.Checked == true)
                {
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價 + 39);
                    進入SQL的價錢 = Convert.ToInt32(訂單總價 + 39);
                }
                else
                {
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元", 訂單總價);
                    進入SQL的價錢 = Convert.ToInt32(訂單總價);
                }
            }
        }
        void 成功失敗()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = " select top 1 訂單編號 from 訂單資料表 order by 訂單編號 desc";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                訂單編號 = ((int)reader["訂單編號"]);
            }
            //Console.WriteLine(訂單編號);
            reader.Close();
            con.Close();
        }

        void 產品細項()
        {
            for (int i = 0; i < 商品名稱.Count; i++)
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = " insert into 訂單資料細節 values (@OrderID, @ProductID, @CheeseID, @PieID, @Uprice);";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@OrderID", 訂單編號);
                cmd.Parameters.AddWithValue("@ProductID", 商品名稱[i]);
                cmd.Parameters.AddWithValue("@CheeseID", 商品起司[i]);
                cmd.Parameters.AddWithValue("@PieID", 商品餅皮[i]);
                cmd.Parameters.AddWithValue("@Uprice", 商品單價[i]);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        private void btn訂單確認送出_Click(object sender, EventArgs e)
        {
            string cfPhone = text訂購人手機.Text;
            cfPhone = cfPhone.Replace("-", "");
            cfPhone = cfPhone.Replace(" ", "");
            text訂購人手機.Text = cfPhone;
            bool ckPhone = Regex.IsMatch(cfPhone, @"^09[0-9]{8}$");
            if(ckPhone)
            {
                if (radio外送.Checked == true)
                {
                    取餐時間 = list訂單時間[comboBox時間.SelectedIndex];
                    string 取餐時間日期 = 取餐日期 + " " + 取餐時間;
                    if ((text訂購人姓名.Text != "") && (text訂購人手機.Text != "") && (text外送地址.Text != ""))
                    {
                        if (GlobalVar.list訂購品項資訊列表.Count > 0)
                        {
                            SqlConnection con = new SqlConnection(strDBconnectionString);
                            con.Open();
                            string strSQL = " insert into 訂單資料表 values (@MemberID, @NewName, @Newphone, @NewMeal, @NewPutime, @Newadders, @NewPrice, (getdate()));";
                            //insert into 訂單資料表 values(109, '王淳方', '0981759218', '自取', '2022/10/28 11:30', '中華一路', 1000, (getdate()));

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@MemberID", GlobalVar.會員ID);
                            cmd.Parameters.AddWithValue("@NewName", text訂購人姓名.Text);
                            cmd.Parameters.AddWithValue("@Newphone", text訂購人手機.Text);
                            cmd.Parameters.AddWithValue("@NewMeal", 自取外送);
                            cmd.Parameters.AddWithValue("@NewPutime", 取餐時間日期);
                            cmd.Parameters.AddWithValue("@Newadders", text外送地址.Text);
                            cmd.Parameters.AddWithValue("@NewPrice", 進入SQL的價錢);
                            cmd.Parameters.AddWithValue("@Newordertime", DateTime.Now);
                            //int intPrice = 0; /*DateTime.Now*/              
                            //Int32.TryParse(txt商品價格.Text, out intPrice);
                            //cmd.Parameters.AddWithValue("@NewName", intPrice);
                            /* int rows = */
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("訂單已成立");
                            成功失敗();
                            產品細項();
                            text訂購人姓名.Clear();
                            text訂購人手機.Clear();
                            text外送地址.Clear();
                            listBox訂購單資訊.Items.Clear();
                            外送加價 = 0;
                            原始訂單總價 = 0;
                            進入SQL的價錢 = 0;
                            GlobalVar.list訂購品項資訊列表.Clear();
                            lbl訂單總價.Text = "訂單總價xxxx元";
                            //成功++;
                        }
                        else
                        {
                            MessageBox.Show("請選擇訂購商品");
                        }

                    }
                    else
                    {
                        MessageBox.Show("所有欄位必填");
                    }
                }
                else if (radio自取.Checked == true)
                {
                    取餐時間 = list訂單時間[comboBox時間.SelectedIndex];
                    string 取餐時間日期 = 取餐日期 + " " + 取餐時間;
                    if ((text訂購人姓名.Text != "") && (text訂購人手機.Text != ""))
                    {
                        if (GlobalVar.list訂購品項資訊列表.Count > 0)
                        {
                            SqlConnection con = new SqlConnection(strDBconnectionString);
                            con.Open();
                            string strSQL = " insert into 訂單資料表 values (@MemberID, @NewName, @Newphone, @NewMeal, @NewPutime, @Newadders, @NewPrice, (getdate()));";
                            //insert into 訂單資料表 values(109, '王淳方', '0981759218', '自取', '2022/10/28 11:30', '中華一路', 1000, (getdate()));

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@MemberID", GlobalVar.會員ID);
                            cmd.Parameters.AddWithValue("@NewName", text訂購人姓名.Text);
                            cmd.Parameters.AddWithValue("@Newphone", text訂購人手機.Text);
                            cmd.Parameters.AddWithValue("@NewMeal", 自取外送);
                            cmd.Parameters.AddWithValue("@NewPutime", 取餐時間日期);
                            cmd.Parameters.AddWithValue("@Newadders", text外送地址.Text);
                            cmd.Parameters.AddWithValue("@NewPrice", 進入SQL的價錢);
                            cmd.Parameters.AddWithValue("@Newordertime", DateTime.Now);
                            //int intPrice = 0; /*DateTime.Now*/              
                            //Int32.TryParse(txt商品價格.Text, out intPrice);
                            //cmd.Parameters.AddWithValue("@NewName", intPrice);
                            /* int rows = */
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("訂單已成立");
                            成功失敗();
                            產品細項();
                            text訂購人姓名.Clear();
                            text訂購人手機.Clear();
                            text外送地址.Clear();
                            listBox訂購單資訊.Items.Clear();
                            外送加價 = 0;
                            原始訂單總價 = 0;
                            進入SQL的價錢 = 0;
                            GlobalVar.list訂購品項資訊列表.Clear();
                            lbl訂單總價.Text = "訂單總價xxxx元";
                            //成功++;
                        }
                        else
                        {
                            MessageBox.Show("請選擇訂購商品");
                        }

                    }
                    else
                    {
                        MessageBox.Show("所有欄位必填");
                    }
                }        
            }
            else
            {
                MessageBox.Show("手機號碼輸入錯誤");
                text訂購人手機.Clear();
            }
           
          
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(訂單總價去SQL);
        }
        private void radio自取_CheckedChanged(object sender, EventArgs e)
        {
            if (radio自取.Checked == true)
            {
                if (GlobalVar.titlID >= 1)
                {
                    進入SQL的價錢 = 外送加價;
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 原始訂單總價, (外送加價));
                    text外送地址.Text = "";
                }
                else
                {
                    進入SQL的價錢 = 外送加價;
                    lbl訂單總價.Text = String.Format("訂單總價:{0}元", 原始訂單總價);
                    text外送地址.Text = "";
                }
            }         
        }

        private void radio外送_CheckedChanged(object sender, EventArgs e)
        {
            //原始訂單總價 = 訂單總價;
            //lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 訂單總價, (訂單總價 * 0.9));
            if (GlobalVar.titlID >= 1)
            {
                if (radio外送.Checked == true)
                {   //內用 Checked等於有勾選
                    if (原始訂單總價 >= 1000)
                    {
                        進入SQL的價錢 = 外送加價;
                        自取外送 = "外送";
                        comboBox時間.Enabled = false;
                        text外送地址.Enabled = true;
                        comboBox時間.Text = "00:00";
                    }
                    else
                    {
                        進入SQL的價錢 = 外送加價 + 39;
                        lbl訂單總價.Text = String.Format("訂單總價:{0}元 會員打9折:{1}元", 原始訂單總價, (外送加價 + 39));
                        自取外送 = "外送";
                        comboBox時間.Enabled = false;
                        text外送地址.Enabled = true;
                        comboBox時間.Text = "00:00";
                    }
                }
                if (radio自取.Checked)
                {   //外帶
                    進入SQL的價錢 = 外送加價;
                    自取外送 = "自取";
                    text外送地址.Enabled = false;
                    comboBox時間.Enabled = true;
                    comboBox時間.Text = "11:30";
                }
            }
            else
            {
                if (radio外送.Checked == true)
                {   //內用 Checked等於有勾選
                    if (原始訂單總價 >= 1000)
                    {
                        自取外送 = "外送";
                        comboBox時間.Enabled = false;
                        text外送地址.Enabled = true;
                        comboBox時間.Text = "00:00";
                    }
                    else
                    {
                        進入SQL的價錢 = 外送加價 + 39;
                        lbl訂單總價.Text = String.Format("訂單總價:{0}元", 原始訂單總價+39);
                        自取外送 = "外送";
                        comboBox時間.Enabled = false;
                        text外送地址.Enabled = true;
                        comboBox時間.Text = "00:00";
                    }
                }
                if (radio自取.Checked)
                {   //外帶
                    進入SQL的價錢 = 外送加價;
                    自取外送 = "自取";
                    text外送地址.Enabled = false;
                    comboBox時間.Enabled = true;
                    comboBox時間.Text = "11:30";
                }
            }                  
        }
              
    }
}
