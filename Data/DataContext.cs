using Microsoft.EntityFrameworkCore;

namespace dijitalPano.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


        public DbSet<NobetciOgrenci> NobetciOgrenciler => Set<NobetciOgrenci>();
        // DbSet'ler burada tanımlanır
        public DbSet<NobetciOgretmen> NobetciOgretmenler => Set<NobetciOgretmen>();
        public DbSet<YemekTakip> YemekTakibi => Set<YemekTakip>();

        
    }
}
