using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    //Data Annotation
    //Data Annotation ile Product tablosu açılırken ürünler ismiyle açılacak demek, veri tabanındaki type'ınıda belirleyebiliyoruz
    //(bir düzenleme yapmış olduk)
    [Table("Katagoriler")]
    public class Category: BaseEntity
    {
        [Required,MaxLength(30)]
        public string CategoryName { get; set; }

        [Column(TypeName = "nvarchar(300) ")]
        public string Description { get; set; }

        //Relational Property 
        //bir category nin birden fazla prodactı olabilir
        public virtual List<Product> Products { get; set; }
    }
}
