using CodeFirst.Enums;
using System;
using System.Diagnostics.Contracts;

namespace CodeFirst.Models
{
    //Tablolarda bulunan ortak alanlarımızı bu sınıfta oluşturacağız
    //Bu sınıftan instance alınmayacak sadece miras verme işlemi için kullanılacak
    public abstract class BaseEntity
    {

        //Oluşturacağımız sınıflar BaseEntityden miras aldığı için,
        //BaseEntity çalışacak ve ben CreatedDate ve Status'in atanmasını istiyorum miras alındığı zaman
        public BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }



        public int ID { get; set; }
        public DataStatus Status { get; set; } 
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
