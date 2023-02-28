using System.Collections.Generic;

namespace CodeFirst.Models
{
    public class Order: BaseEntity
    {
        //foreign key
        //foreign key değerini vurada tanımlamamız gerekiyor(bire çok ilişkide) bir olan taraf AppUser olduğu için
        public int AppUserID { get; set; }

        //Rational Property
        // Order bir tane AppUser içerebilir demiş olduk
        public virtual AppUser AppUser { get; set; }    

        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
