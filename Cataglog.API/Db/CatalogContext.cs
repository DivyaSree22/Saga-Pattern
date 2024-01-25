using Cataglog.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cataglog.API.Db
{
    public class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {

        }

        public DbSet<CatalogItem> CatalogItems { get; set; }
    }
}
