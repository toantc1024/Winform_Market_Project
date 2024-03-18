using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_Market_Project.Models
{
    public class Product
    {
        private int productID;
        private string productName;
        private string des_info;
        private string des_status;
        private DateTime uploadedDate;
        private int original_price;
        private int sell_price;
        private int user_id;
        private int cat_id;

        public Product(int productID, string productName, string des_info, string des_status, DateTime uploadedDate, int original_price, int sell_price, int user_id, int cat_id)
        {
            this.productID=productID;
            this.productName=productName;
            this.des_info=des_info;
            this.des_status=des_status;
            this.uploadedDate=uploadedDate;
            this.original_price=original_price;
            this.sell_price=sell_price;
            this.user_id=user_id;
            this.cat_id=cat_id;
        }

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Des_info { get => des_info; set => des_info = value; }
        public string Des_status { get => des_status; set => des_status = value; }
        public DateTime UploadedDate { get => uploadedDate; set => uploadedDate = value; }
        public int Original_price { get => original_price; set => original_price = value; }
        public int Sell_price { get => sell_price; set => sell_price = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public int Cat_id { get => cat_id; set => cat_id=value; }
    }
}
