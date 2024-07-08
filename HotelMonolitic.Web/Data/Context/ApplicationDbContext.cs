using Microsoft.EntityFrameworkCore;

namespace HotelMonolitic.Web.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        
        }
    }
}
