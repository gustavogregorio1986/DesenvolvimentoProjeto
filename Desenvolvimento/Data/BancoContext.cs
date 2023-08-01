using Desenvolvimento.Models;
using Microsoft.EntityFrameworkCore;

namespace Desenvolvimento.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<ProtocoloModel> Protocolos { get; set; }
    }
}
