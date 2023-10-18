using Microsoft.EntityFrameworkCore;

namespace SP3072118MVCDB.Models;

public class MvcDBContext : DbContext
{
    public DbSet<Cliente> Cliente { get; set; }
    
    public DbSet<Venda> Venda { get; set; }
    
    public MvcDBContext(DbContextOptions<MvcDBContext> options) : base(options)
    {
        
    }
}