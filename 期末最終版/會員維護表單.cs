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
using static System.Net.Mime.MediaTypeNames;

namespace 期末最終版
{
    public partial class 會員維護表單 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        public 會員維護表單()
        {
            InitializeComponent();
        }

        private void 會員維護表單_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pizza";
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            產生全部會員資料列表();
            dataGridView會員資料.AllowUserToAddRows = false;
        }
        void 清空欄位()
        {
            lblID.Text = "";
            txt用戶名稱.Clear();
            txt電話.Clear();
            txt密碼.Clear();
            txt職稱.Clear();
        }
        private void btn會員筆數_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from member where 職稱=1 ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;


            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string 姓名 = reader["用戶名稱"].ToString();
                string 電話 = reader["手機號碼"].ToString();
                string 職稱代號 = reader["職稱"].ToString();
                

                strMsg += string.Format("ID:{0}, 姓名:{1}, 電話:{2}, 職稱:{3}\n", id, 姓名, 電話, 職稱代號);
                i += 1;
            }
            strMsg += "筆數:" + i.ToString();

            reader.Close();
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btn員工資料_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            string strSQL = "select * from member where 職稱>1 ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string strMsg = "";
            int i = 0;


            while (reader.Read())
            {
                string id = reader["ID"].ToString();
                string 姓名 = reader["用戶名稱"].ToString();
                string 電話 = reader["手機號碼"].ToString();
                string 職稱代號 = reader["職稱"].ToString();


                strMsg += string.Format("ID:{0}, 姓名:{1}, 電話:{2}, 職稱:{3}\n", id, 姓名, 電話, 職稱代號);
                i += 1;
            }
            strMsg += "筆數:" + i.ToString();

            reader.Close();
            con.Close();

            MessageBox.Show(strMsg);
        }

        private void btn資料收尋_Click(object sender, EventArgs e)
        {
            if (txt用戶名稱.Text != "")
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "select * from member where 用戶名稱 like @SearchName;";  //搜尋姓名有大的
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchName", "%" + txt用戶名稱.Text + "%");
                //Parameters防駭客檢查       參數名稱          %姓名%參數名稱分大小寫參數
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblID.Text = reader["ID"].ToString();
                    txt用戶名稱.Text = reader["用戶名稱"].ToString();
                    txt電話.Text = reader["手機號碼"].ToString();
                    txt密碼.Text = reader["密碼"].ToString();
                    txt職稱.Text = reader["職稱"].ToString();
                }
                else
                {
                    MessageBox.Show("查無此人");
                    清空欄位();
                }

                reader.Close();
                con.Close();
            }
            else
            {
                MessageBox.Show("請輸入姓名");
            }
        }

        private void btn資料修改_Click(object sender, EventArgs e)
        {
            //lblID.Text = reader["ID"].ToString();
            //txt用戶名稱.Text = reader["用戶名稱"].ToString();
            //txt電話.Text = reader["手機號碼"].ToString();
            //txt密碼.Text = reader["密碼"].ToString();
            //txt職稱.Text = reader["職稱"].ToString();
            int intID = 0;
            Int32.TryParse(lblID.Text, out intID);

            if ((intID > 0) && (txt用戶名稱.Text != "") && (txt電話.Text != "") && (txt密碼.Text != "") && (txt職稱.Text != ""))
            {
                SqlConnection con = new SqlConnection(strDBconnectionString);
                con.Open();
                string strSQL = "update member set 用戶名稱=@NewName ,手機號碼=@NewPhone ,密碼=@NewPassword ,職稱=@Newtitle where ID=@SearchId;;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewName", txt用戶名稱.Text);
                cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                cmd.Parameters.AddWithValue("@Newtitle", txt職稱.Text);
                cmd.Parameters.AddWithValue("@SearchId", intID);
                int rows = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(String.Format("異動成功,{0} 個資料列受到影響", rows));
            }
        }

        private void btn新增資料_Click(object sender, EventArgs e)
        {
            if (txt電話.Text != "")
            {
                List<string> 會員手機帳號比對 = new List<string>();
                SqlConnection conn = new SqlConnection(strDBconnectionString);
                string strSQL1 = "select * from member";
                conn.Open();
                SqlCommand cmd1 = new SqlCommand(strSQL1, conn);
                SqlDataReader reader = cmd1.ExecuteReader();

                while (reader.Read())
                {
                    string 會員手機 = reader["手機號碼"].ToString();
                    會員手機帳號比對.Add(會員手機);
                }
                reader.Close();
                conn.Close();

                for (int i = 0; i < 會員手機帳號比對.Count; i++)
                {
                    if (會員手機帳號比對[i] == txt電話.Text)
                    {
                        MessageBox.Show("此電話號碼已使用過");
                        清空欄位();
                        break;
                    }
                }
                if ((txt用戶名稱.Text != "") && (txt電話.Text != "") && (txt密碼.Text != "") && (txt職稱.Text != ""))
                {
                    SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string strSQL = "insert into member values(@NewPhone,@NewName,@NewPassword,@Newtitle);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewName", txt用戶名稱.Text);
                    cmd.Parameters.AddWithValue("@NewPhone", txt電話.Text);
                    cmd.Parameters.AddWithValue("@NewPassword", txt密碼.Text);
                    cmd.Parameters.AddWithValue("@Newtitle", txt職稱.Text);

                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show(String.Format("新增成功,{0} 個資料列受到影響", rows));
                }              
            }
            else
            {
                MessageBox.Show("請輸入資料");
            }
        }

        //private void btn刪除資料_Click(object sender, EventArgs e)
        //{
        //    int intID = 0;
        //    Int32.TryParse(lblID.Text, out intID);

        //    if (intID > 0)
        //    {
        //        SqlConnection con = new SqlConnection(strDBconnectionString);
        //        con.Open();
        //        string strSQL = "delete member where id= @DeleteId;";
        //        SqlCommand cmd = new SqlCommand(strSQL, con);
        //        cmd.Parameters.AddWithValue("@DeleteId", intID);

        //        int rows = cmd.ExecuteNonQuery();//只執行不查詢 回傳授影響資料變數
        //        con.Close();
        //        清空欄位();
        //        MessageBox.Show(String.Format("刪除成功,{0} 個資料列受到影響", rows));

        //    }
        //}

        private void btn清空欄位_Click(object sender, EventArgs e)
        {
            清空欄位();
        }
         void 產生全部會員資料列表()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            //string strSQL = "select * from person;";
            string strSQL = "select ID, 用戶名稱, 手機號碼, 密碼, 職稱 from member where ID > 101;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) //只要有reader都可以用dataGridView呈現
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView會員資料.DataSource = dt;
            }
            reader.Close();
            con.Close();

        }   
        private void dataGridView會員資料_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string strSelectedID = dataGridView會員資料.Rows[e.RowIndex].Cells[0].Value.ToString();
                //Rows是直的數下來   Cells是橫的
                int intSelID = 0;
                bool isID = Int32.TryParse(strSelectedID, out intSelID);

                if (isID)
                {
                    SqlConnection con = new SqlConnection(strDBconnectionString);
                    con.Open();
                    string strSQL = "select * from member where ID = @SearchID;";  //搜尋姓名有大的
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@SearchID", intSelID);
                    //Parameters防駭客檢查       參數名稱          %姓名%參數名稱分大小寫參數
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        lblID.Text = reader["ID"].ToString();
                        txt用戶名稱.Text = reader["用戶名稱"].ToString();
                        txt電話.Text = reader["手機號碼"].ToString();
                        txt密碼.Text = reader["密碼"].ToString();
                        txt職稱.Text = reader["職稱"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("查無此人");
                        清空欄位();
                    }

                    reader.Close();
                    con.Close();
                }
            }
        }
    }
}
