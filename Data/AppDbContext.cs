using GestionCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace GestionCarros.Data;
public class AppDbContext : DbContext
{

    public DbSet<Carro> Carros { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

}