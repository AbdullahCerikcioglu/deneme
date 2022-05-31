using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewE_IsTicaret.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        // aşağida siparişi veren kullanıcın Id tanımlamız gerekir
        public string AppUser { get; set; }
        public DateTime OrderDate { get; set; }  //sipariş tarih 
        public double OrderPrice { get; set; }  //sipariş fiyat 
        public String OrderStatu { get; set; }  //sipariş durumu 
        public String CellPhone { get; set; } 
        public String Address { get; set; } 
        public String PostalCode { get; set; } 
        public String Name { get; set; }
        // sipariş için appuser tablomuza bağlanntı sağladık 
        [ForeignKey("AppUserId")]
        public AppUser appUser { get; set; }
    }
}
