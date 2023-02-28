using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    //Data Annotation
    //Data Annotation ile Product tablosu açılırken ürünler ismiyle açılacak demek, veri tabanındaki type'ınıda belirleyebiliyoruz
    //(bir düzenleme yapmış olduk)
    [Table("Ürünler")]

    public class Product: BaseEntity
    {
        [Column("Ürün İsmi", TypeName ="nvarchar(50) "), MinLength(5)]
        [Required]
        public string ProductName { get; set; }

        [Column ("Birim Fiyatı", TypeName ="numeric(18,1)")]//toplam basamak sayısı 18 virgülden sonra bir basamak
        public decimal UnitPrice{ get; set; }
        public  short UnitsInStock { get; set; }

        //foreign key !!!!!!!
        //foreign key değerini vurada tanımlamamız gerekiyor(bire çok ilişkide) bir olan taraf Category olduğu için
        public int CategoryID { get; set; }

        //Relational Property
        //Product bir tane Category  içerebilir demiş olduk
        public virtual Category Category { get; set; }

        public virtual List<OrderDetail> OrderDetails { get; set; }


    }
}
