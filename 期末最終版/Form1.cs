using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 期末最終版
{
    public partial class from1 : Form
    {
        bool sidebarExpand;
        bool sidebar產品;
        bool sidebar會員;
        public from1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void from1_Load(object sender, EventArgs e)
        {
            loadfrom(new FormHome());

            panel產品新修.Visible = false;
            panel會員維護.Visible = false;
            panel登出.Visible = false;
            panel歷史訂單.Visible = false;
        }
        private void loadfrom(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
          
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                }            
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                }
            }
        }
        private void timer產品_Tick(object sender, EventArgs e)
        {
            if (sidebar產品)
            {
                panel產品.Height -= 10;
                if (panel產品.Height == panel產品.MinimumSize.Height)
                {
                    sidebar產品 = false;
                    timer產品.Stop();
                }
            }
            else
            {
                panel產品.Height += 10;
                if (panel產品.Height == panel產品.MaximumSize.Height)
                {
                    sidebar產品 = true;
                    timer產品.Stop();
                }
            }

        }

        private void timer會員_Tick(object sender, EventArgs e)
        {
            if (sidebar會員)
            {
                panel會員.Height -= 10;
                if (panel會員.Height == panel會員.MinimumSize.Height)
                {
                    sidebar會員 = false;
                    timer會員.Stop();
                }
            }
            else
            {
                panel會員.Height += 10;
                if (panel會員.Height == panel會員.MaximumSize.Height)
                {
                    sidebar會員 = true;
                    timer會員.Stop();
                }
            }
        }

        private void menubtn_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            loadfrom(new FormHome());
        }
        private void btn產品介紹列表_Click(object sender, EventArgs e)
        {
            timer產品.Start();
        }
        private void btn主餐_Click(object sender, EventArgs e)
        {
            GlobalVar.listName ="主餐";
            loadfrom(new Form產品());

        }   
        private void btn配餐_Click(object sender, EventArgs e)
        {
            GlobalVar.listName ="配餐";
            loadfrom(new Form產品());
        }   
        private void btn飲品甜點_Click(object sender, EventArgs e)
        {
            GlobalVar.listName ="甜點飲料";
            loadfrom(new Form產品());
        }
        private void btn購物車_Click(object sender, EventArgs e)
        {
            loadfrom(new Shopping_cart());
        }
        private void btn註冊登入_Click(object sender, EventArgs e)
        {
            timer會員.Start();
            
        }
        private void btn註冊會員_Click(object sender, EventArgs e)
        {
            loadfrom(new 註冊會員());
        }
        void 操控的事件()
        {
            if (GlobalVar.titlID == 100)
            {
                panel產品新修.Visible = true;
                panel會員維護.Visible = true;
                panel會員.Visible = false;
                panel登出.Visible = true;
                panel歷史訂單.Visible = true;
            }
            else if (GlobalVar.titlID == 10)
            {
                panel產品新修.Visible = true;
                panel會員.Visible = false;
                panel登出.Visible = true;
                panel歷史訂單.Visible = true;
            }
            else if (GlobalVar.titlID == 1)
            {
                panel產品新修.Visible = false;
                panel會員維護.Visible = false;
               panel會員.Visible = false;
                panel登出.Visible = true;
                panel歷史訂單.Visible = true;
            }
            else
            {
                panel產品新修.Visible = false;
                panel會員維護.Visible = false;
            }
        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            member form2 = new member();
            form2.能動的事件 += new member.無參數的Void委派(操控的事件);
            loadfrom(form2);

        }

        private void btn新增商品_Click(object sender, EventArgs e)
        {
            loadfrom(new 新增商品表單());
        }

        private void btn新增商品_Click_1(object sender, EventArgs e)
        {
            loadfrom(new 新增商品表單());
            GlobalVar.所選id = 0;
        }
        private void btn會員維護_Click(object sender, EventArgs e)
        {
            loadfrom(new 會員維護表單());
        }
    
        private void btn歷史訂單_Click(object sender, EventArgs e)
        {
            loadfrom(new 歷史訂單());
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

        private void btn登出_Click(object sender, EventArgs e)
        {
            GlobalVar.titlID = 0;
            GlobalVar.會員ID = 101;
            GlobalVar.會員名稱 = "訪客";
            loadfrom(new FormHome());
            panel產品新修.Visible = false;
            panel會員維護.Visible = false;
            this.panel會員.Visible = true;
            panel登出.Visible = false;
            panel歷史訂單.Visible = false;
            MessageBox.Show("登出成功");
        }
    }
}
