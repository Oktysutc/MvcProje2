using Microsoft.EntityFrameworkCore;
using MvcProje2.Models;

namespace MvcProje2.Utility
    
{
    public class UygulamaDbContext: DbContext
    {
        public UygulamaDbContext(DbContextOptions<UygulamaDbContext>options ) : base(options) { }
        public DbSet<Tur> Turlerim { get; set; }                   // tekrar bi köprü işlemi yapılıyor burada
    }
}
