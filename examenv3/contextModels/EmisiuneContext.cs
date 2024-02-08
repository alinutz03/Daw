
using examenv3.Models;
using Microsoft.EntityFrameworkCore;


namespace examenv3.contextModels
{
    public class EmisiuneContext : DbContext
    {
        public EmisiuneContext(DbContextOptions<EmisiuneContext> options) : base(options) { }
       public DbSet<Emisiune> emisiuni { get; set; }
        public DbSet<Canal_TV> canale {  get; set; }
    }
}
