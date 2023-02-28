namespace CodeFirst.Models
{
    public class AppUserDetail: BaseEntity
    {
        public string FirtstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //iki taraftan birinde foreign key yazmak zorundayız (bu bir kolondur ve integer türündedir)
        //AppUserID ile AppUser in id eşleşecek ve ilişki sağlanmış olacak
        //ilişkisel property(AppUser) nasıl yazdıysam onun sonuna ID koyunca bunun bir foregn key olduğunu anlıyor
        public int AppUserID { get; set; }


        //Relational Property
        //AppUserDetail bir tane AppUser içerebilir demiş olduk
        public AppUser AppUser  { get; set; }
    }
}
