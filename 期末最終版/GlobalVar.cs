using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 期末最終版
{
    internal class GlobalVar
    {
        public static string listName;//觸發按鈕帶入字串
        public static int 所選id;//listView商品展示.SelectedItems[0].Tag 
        public static string productname;//尋找所選商品名稱
        public static int productprice;//尋找所選商品價格
        public static string 餅皮名稱;
        public static string 起司名稱;
        public static List<ArrayList> list訂購品項資訊列表 = new List<ArrayList>();
        public static DateTime 上架日期;
        public static int titlID = 0;
        public static string 會員手機;
        public static int 會員ID=101;
        public static List<int> 商品ID = new List<int>();
        public static string 會員名稱="訪客";
    }
}