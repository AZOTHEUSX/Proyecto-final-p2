using Microsoft.EntityFrameworkCore;
using HotelMonolitic.Web.Data.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

 

}