using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewE_IsTicaret.Models
{
    public class Cart
    {
        //aliş veriş sepeti modelimiz
        public Cart()
        {
            Count = 1;
        }
        [Key]
        public int Id { get; set; }
        public string AppUserId { get; set; }
        public int ProductId{ get; set; }
        public int Count { get; set; }
        public double Price{ get; set; }


        // kullanıcıdaki alanı halletmemiz için appuser alanına bağlanılması gerekir appuser tablosuna bağlantı işini
        // AppUserId bağlantı yapabilmemiz için asağidkileri yazdık  yani AppuserId ile   appuser tablosuna bağlan demek istedim

        [ForeignKey("AppUserId")]
        public AppUser AppUser { get; set; }

        // appuser için yaptıklarımızı product içinde yapıyoruz aşağidaki kodda
        [ForeignKey("ProductId")]
        public Product product { get; set; }
    }
}
