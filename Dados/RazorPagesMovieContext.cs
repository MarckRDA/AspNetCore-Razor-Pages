using Microsoft.EntityFrameworkCore;
using RazorPagesAspNet.Models;

namespace RazorPagesAspNet.Dados
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(DbContextOptions<RazorPagesMovieContext> options) : base(options)
        {            
        }

        public DbSet<Movie> Movie { get; set; }
    }
}