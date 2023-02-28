using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class OrderDetail: BaseEntity
    {
        //bu sınıf Order ve Product sınıfları çoka çok bir ilişkide olabilsin diye oluşturulmuş bir sınıf.

        //hem OrderID hem ProductID primary key olmak zorunda ama BaseEntityden miras aldığım için burada bir de ID alanı var benim ID kolonuna, OrderDetail tablosu için ihtiyacım yok (işte bunları yapabilmek için context sınıfıma gidiyorum OnModelCreating methoduna)
        public int OrderID { get; set; }
 
        public int ProductID { get; set; }

        public short Quantity { get; set; }

        [Column(TypeName = "numeric(18,1)")]//toplam basamak sayısı 18 virgülden sonra bir tane basamak
        public decimal? TotalPrice { get; set; }  
        // ? -TotalPrice null geçilebilir demek oluyor(normalde decimal int vs.null geçilemez 0 olarka değer alır bir şey atanmazssa)
        // string değerler kendiliğinden null alır bir şey atanmassa

        //Relational Property
        public virtual Order Order { get; set; }
        public virtual  Product Product { get; set; }
    }
}
