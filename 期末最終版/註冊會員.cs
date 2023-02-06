using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末最終版
{
    public partial class 註冊會員 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        public 註冊會員()
        {
            InitializeComponent();
        }

     

        private void 註冊會員_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @"."; //代表伺服器名稱
                                    //.點本機的意思 @不處理特殊符號
            scsb.InitialCatalog = "pizza";//database 資料庫名稱
            scsb.IntegratedSecurity = true;//資料庫驗證
            strDBconnectionString = scsb.ToString();//可以設定成全域變數 轉成字串
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cfPhone = text手機號碼.Text;
            cfPhone = cfPhone.Replace("-", "");
            cfPhone = cfPhone.Replace(" ", "");
            text手機號碼.Text = cfPhone;
            bool ckPhone = Regex.IsMatch(cfPhone, @"^09[0-9]{8}$");
            if (ckPhone)
            {
                if (text手機號碼.Text != "")
                {
                    List<string> 會員手機帳號 = new List<string>();
                    SqlConnection conn = new SqlConnection(strDBconnectionString);
                    string strSQL1 = "select * from member";
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
                    SqlDataReader reader = cmd1.ExecuteReader();

                    while (reader.Read())
                    {
                        string 會員手機 = reader["手機號碼"].ToString();
                        會員手機帳號.Add(會員手機);
                    }
                    reader.Close();
                    conn.Close();
                    int k = 0;
                    for (int i = 0; i < 會員手機帳號.Count; i++)
                    {
                        if (會員手機帳號[i] == text手機號碼.Text)
                        {
                            MessageBox.Show("此電話號碼已使用過");
                            text手機號碼.Clear();
                            text用戶名稱.Clear();
                            text密碼.Clear();
                            text確認密碼.Clear();
                            k = 1;
                            break;
                        }
                    }
                    if (k == 0)
                    {
                        if (text用戶名稱.Text != "")
                        {
                            if (text密碼.Text != "")
                            {
                                if ((text確認密碼.Text != "") && (text確認密碼.Text == text密碼.Text))
                                {
                                    SqlConnection con = new SqlConnection(strDBconnectionString);
                                    con.Open();
                                    string strSQL = "insert into member values(@NewPhone,@NewUser,@NewPassword,1);";
                                    SqlCommand cmd = new SqlCommand(strSQL, con);
                                    cmd.Parameters.AddWithValue("@NewPhone", text手機號碼.Text);
                                    cmd.Parameters.AddWithValue("@NewUser", text用戶名稱.Text);
                                    cmd.Parameters.AddWithValue("@NewPassword", text密碼.Text);
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                    MessageBox.Show(String.Format("創建成功"));
                                    text手機號碼.Clear(); ;
                                    text用戶名稱.Clear(); ;
                                    text密碼.Clear(); ;
                                    text確認密碼.Clear(); ;                                

                                }
                                else
                                {
                                    MessageBox.Show("兩次輸入密碼必須一致");
                                }
                            }
                            else
                            {
                                MessageBox.Show("密碼輸入錯誤");
                            }
                        }
                        else
                        {
                            MessageBox.Show("用戶名稱輸入錯誤");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("手機號碼輸入錯誤");
                text手機號碼.Clear();
                text用戶名稱.Clear();
                text密碼.Clear();
                text確認密碼.Clear();
            }
        }

        private void 顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (顯示密碼.Checked == true)
            {
                text密碼.PasswordChar = '\0';
            }
            else if (顯示密碼.Checked == false)
            {
                text密碼.PasswordChar = '★';
            }
        }

        private void 確認顯示密碼_CheckedChanged(object sender, EventArgs e)
        {
            if (確認顯示密碼.Checked == true)
            {
                text確認密碼.PasswordChar = '\0';
            }
            else if (確認顯示密碼.Checked == false)
            {
                text確認密碼.PasswordChar = '★';
            }
        }
    }
}
