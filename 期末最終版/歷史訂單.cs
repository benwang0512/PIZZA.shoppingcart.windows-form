using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末最終版
{
    public partial class 歷史訂單 : Form
    {
        SqlConnectionStringBuilder scsb;
        string strDBconnectionString = "";
        public 歷史訂單()
        {
            InitializeComponent();
        }

        private void 歷史訂單_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "pizza";
            scsb.IntegratedSecurity = true;
            strDBconnectionString = scsb.ToString();
            dataGridView會員資料.CurrentCell = null;
            //this.dataGridView會員資料.DefaultCellStyle.ForeColor = Color.Black;
            //this.dataGridView會員資料.DefaultCellStyle.BackColor = Color.Yellow;
            dataGridView會員資料.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView會員資料.DefaultCellStyle.SelectionBackColor = Color.DarkOrange;
            dataGridView會員資料.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView會員資料.AllowUserToAddRows = false;

            產生歷史訂單料列表();
        }
        void 產生歷史訂單料列表()
        {
            SqlConnection con = new SqlConnection(strDBconnectionString);
            con.Open();
            //string strSQL = "select * from person;";
            string strSQL = "select a.訂單編號, 訂購人姓名, 訂購人電話,[外帶 or 外送],商品總價,訂購時間 from 訂單資料表 as a join member as b on a.會員ID = b.ID where ID = @NewID;";
        
            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@NewID", GlobalVar.會員ID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView會員資料.DataSource = dt;
                //dataGridView會員資料.Rows[2].Cells[2].Style.BackColor = Color.DarkOrange;
            }
            reader.Close();
            con.Close();

        }

        private void dataGridView會員資料_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            listBox訂購單資訊.Items.Clear();
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
                    string strSQL = "select  * FROM 訂單資料表 AS A JOIN member as B on A.會員ID = B.ID join 訂單資料細節 as C on C.訂單編號 = A.訂單編號 where C.訂單編號 = @OrderID";  //搜尋姓名有大的
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@OrderID", intSelID);
                    //Parameters防駭客檢查       參數名稱          %姓名%參數名稱分大小寫參數
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int 訂單編號 = ((int)reader["訂單編號"]);
                        string 商品名稱 = reader["商品名稱"].ToString();
                        string 起司 = reader["起司"].ToString();
                        string 餅皮 = reader["餅皮"].ToString();
                        int 單價 = ((int)reader["商品單價"]);
                        //DateTime 訂購時間 = ((DateTime)reader["訂購時間"]); 

                        string str歷史細項 = string.Format("訂單編號:{0} 商品名稱:{1} {2} {3} 單價:{4} ", 訂單編號, 商品名稱, 起司, 餅皮, 單價);/*(訂購時間.ToString("yyyy-MM-dd")*/
                        listBox訂購單資訊.Items.Add(str歷史細項);
                    }                  
                    reader.Close();
                    con.Close();        
                }                 
            }
        }
    }
}

