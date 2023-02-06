using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using 期末最終版.Properties;

namespace 期末最終版
{
    public partial class member : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        string i;
        public member()
        {
            InitializeComponent();
        }
        private void loadfrom(object Form)
        {

            if (this.panel會員.Controls.Count > 0)
                this.panel會員.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel會員.Controls.Add(f);
            this.panel會員.Tag = f;
            f.Show();
        }
        public delegate void 無參數的Void委派();
        public event 無參數的Void委派 能動的事件;

        private void member_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //代表伺服器名稱
                                    //.點本機的意思 @不處理特殊符號
            scsb.InitialCatalog = "pizza";//database 資料庫名稱
            scsb.IntegratedSecurity = true;//資料庫驗證
            strDBconnectionString = scsb.ToString();//可以設定成全域變數 轉成字串
        }
        void 消失()
        {
            text手機號碼登入.Visible = false;
            text密碼登入.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            checkBox顯示密碼.Visible = false;
            btn登入按鈕.Visible = false;
            btn註冊.Visible = false;
        }

        private void btn登入按鈕_Click(object sender, EventArgs e)
        {
            //string cfPhone = text手機號碼登入.Text;
            //cfPhone = cfPhone.Replace("-", "");
            //cfPhone = cfPhone.Replace(" ", "");
            //text手機號碼登入.Text = cfPhone;
            //bool ckPhone = Regex.IsMatch(cfPhone, @"^09[0-9]{8}$");

            i = text手機號碼登入.Text;
            List<string> 會員手機帳號 = new List<string>();
            List<string> 會員密碼登入 = new List<string>();
            List<string> 會員姓名 = new List<string>();
            List<int> 職稱ID = new List<int>();
            SqlConnection con = new SqlConnection(strDBconnectionString);
            string strSQL = "select * from member";
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string 會員手機 = reader["手機號碼"].ToString();
                string 會員密碼 = reader["密碼"].ToString();
                string 會員名稱 = reader["用戶名稱"].ToString();
                int 職稱 = ((int)reader["職稱"]);

                會員手機帳號.Add(會員手機);
                會員密碼登入.Add(會員密碼);
                會員姓名.Add(會員名稱);
                職稱ID.Add(職稱);
            }
            reader.Close();
            con.Close();
            int k = 0;
            //if(ckPhone)
            //{
            for (int i = 0; i < 會員手機帳號.Count; i++)
            {

                if (會員手機帳號[i] == text手機號碼登入.Text && 會員密碼登入[i] == text密碼登入.Text && 職稱ID[i] == 100)
                {
                    k = 1;
                    GlobalVar.titlID = 100;
                    MessageBox.Show("Boss王淳方登入成功");
                    會員ID();
                    GlobalVar.會員名稱 = "Boss王淳方";
                    if (能動的事件 != null) { 能動的事件(); }
                    GlobalVar.listName = "主餐";
                    消失();
                    loadfrom(new Form產品());  
                    break;
                }
                else if (會員手機帳號[i] == text手機號碼登入.Text && 會員密碼登入[i] == text密碼登入.Text && 職稱ID[i] == 10)
                {
                    k = 1;
                    GlobalVar.titlID = 10;
                    MessageBox.Show("員工" + 會員姓名[i] + "登入成功");
                    GlobalVar.會員名稱 = "員工" + 會員姓名[i];
                    會員ID();
                    消失();
                    GlobalVar.listName = "主餐";
                    if (能動的事件 != null) { 能動的事件(); }
                    loadfrom(new Form產品());
                    break;
                }
                else if (會員手機帳號[i] == text手機號碼登入.Text && 會員密碼登入[i] == text密碼登入.Text && 職稱ID[i] == 1)
                {
                    k = 1;
                    GlobalVar.titlID = 1;
                    MessageBox.Show("歡迎" + 會員姓名[i] + "登入成功");
                    GlobalVar.會員名稱 = 會員姓名[i];
                    會員ID();
                    GlobalVar.listName = "主餐";
                    消失();
                    if (能動的事件 != null) { 能動的事件(); }
                    loadfrom(new Form產品());                  
                    break;
                }
                else if (職稱ID[i] == -1)
                {
                    MessageBox.Show("此帳號已被停用");
                    k = 1;
                }
            }
            if (k == 0)
            {
                MessageBox.Show("帳號密碼輸入錯誤");
                text手機號碼登入.Clear();
                text密碼登入.Clear();
                會員手機帳號.Clear();
                會員密碼登入.Clear();
                會員姓名.Clear();
                職稱ID.Clear();
            }
        }
        //else
        //{
        //    MessageBox.Show("手機格式輸入錯誤");
        //}      

        void 會員ID()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            string strSQL = "select * from member where 手機號碼 = @phone ";
            con.Open();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@phone", i);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                GlobalVar.會員ID = ((int)reader["ID"]);
                Console.WriteLine(GlobalVar.會員ID);
            }         

        }
        private void checkBox顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox顯示密碼.Checked == true)
            {
                text密碼登入.PasswordChar = '\0';
            }
            else if (checkBox顯示密碼.Checked == false)
            {
                text密碼登入.PasswordChar = '★';
            }
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            //註冊會員 myFormDetail = new 註冊會員();           
            //myFormDetail.ShowDialog();
            label6.Visible = false;
            label5.Visible = false;
            text手機號碼登入.Visible = false;
            text密碼登入.Visible = false;
            checkBox顯示密碼.Visible = false;
            checkBox顯示密碼.Visible = false;
            btn登入按鈕.Visible = false;
            btn註冊.Visible = false;
            loadfrom(new 註冊會員());
        }

        private void panel會員_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
