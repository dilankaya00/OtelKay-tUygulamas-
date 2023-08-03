using Microsoft.EntityFrameworkCore;

namespace EsmeHotel.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        //Müşteri
        public virtual DbSet<Musteri> Musteris { get; set; }
        //Personel
        public virtual DbSet<Personel> Personels{ get; set; }

    }
}
