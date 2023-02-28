using CodeFirst.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    //burada bulunan propertyler AppUser tablosunun kolonlarını ifade ediyor 
    public class AppUser: BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        [NotMapped] //RePassword alanının database de bie kolan olarka açıkmasını istemiyorum demiş olduk 
        public string RePassword { get; set; }

        public Role Role { get; set; }

        //Relational Property
        //buraya bir property daha ekliyoruz bu bir kolon değil ilişkinin nasıl olduğunu açıklamak için kullancağız
        //AppUser bir tane AppUserDetail içerebilir demiş olduk
        //AppUser birden çok Order içerebilir demiş olduk
        public virtual AppUserDetail AppUserDetail { get; set; }

        public virtual List<Order> Orders { get; set; }


        //public virtual AppUserDetail  AppUserDetail { get; set; }
        //burada lazy loading yapmış oluyoruz
        //AppUser tablosuna istek attığımızda AppUserDetail de gelsin istersek Relational Property içerisine virtual keyvordunu koymak gerekiyor
    }
}
