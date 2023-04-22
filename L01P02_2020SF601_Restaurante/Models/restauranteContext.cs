using Microsoft.EntityFrameworkCore;
using L01P02_2020SF601_Restaurante.Models;

namespace L01P02_2020SF601_Restaurante.Models
{
    public class restauranteContext : DbContext
    {
        public restauranteContext(DbContextOptions<restauranteContext> dbContext) : base(dbContext)
        {


        }
        public DbSet<L01P02_2020SF601_Restaurante.Models.pedidos>? pedidos { get; set; }
        public DbSet<L01P02_2020SF601_Restaurante.Models.clientes>? clientes { get; set; }
        public DbSet<L01P02_2020SF601_Restaurante.Models.platos>? platos { get; set; }
        public DbSet<L01P02_2020SF601_Restaurante.Models.motoristas>? motoristas { get; set; }
        
    }
}
