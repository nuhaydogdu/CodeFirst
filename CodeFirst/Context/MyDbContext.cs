using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CodeFirst.Context
{
    public class MyDbContext: DbContext
    {
        //bağlantı adresini constructor üzerinden alma işlemi (*)
        //Veri tabanı bağlantısı için MyDbContext içerisine bir constructor oluşturduk ve dependency injection üzerinden DbContextOptions'ı(DbContextOptions<MyDbContext> options) aldık.  
        //Base keywordu: Miras alınan sınıfın constructoruna bir parametre göndermek için kullanılıyor.(yani biz burada miras aldıpımız üst sınıf olan DbContext constructoruna bir options göndermiş olduk)
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options )
        {
                
        }


        //OnConfiguring() Burası veri tabanı bağlantısı yapmanın birinci yolu.
        //OnConfiguring methodunu kullanarak veri tabanı bağlantısını sağlıyoruz
        //ikinci yöntem ise Constructor üzerinden Dependdency İnjection ile bunu yapmak (*)

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("sever=.;database=BookStore;uid=sa:pwd=25Nezehe34");
            base.OnConfiguring(optionsBuilder);
        }
        */



        //Veri tabanı ilk defa oluşturulurken tetiklenen bir method -OnModelCreating()
        //Bu method sayesinde tablolar oluşturulamadan veri tabanı konfrigasyonlarını yapabiliriz(tabloların ismini, kolonların özelliklerini değiştirebiliriz
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //orderDetail modeli içerisindeki ID alanını databasee aktarılmasını istemiyorum (burada yapmış olduğum fluent api)
            //OrderID, ProductID leride primary key haline getirdik

            modelBuilder.Entity<OrderDetail>().Ignore("ID");  
            modelBuilder.Entity<OrderDetail>().HasKey("OrderID", "ProductID");
        }




        //Models klasöründe oluşturmuş olduğumuz sınıflarımızın veri tabanında tablo olarak karşılık bulabilmesi için DbContext sınıfı içerisinde DbSet lerini yazmamız gerekiyor 
        public DbSet<AppUser> Users { get; set; }  //DbSet<AppUser>, Users => tabloya çevirdiğimiz class, veri tabanındaki tablo ismi

        public DbSet<AppUserDetail> UserDetails{ get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Order> Orders { get; set; } 
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<Product> Products { get; set; }


    }
}
