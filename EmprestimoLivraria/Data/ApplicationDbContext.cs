using EmprestimoLivraria.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivraria.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<EmprestimosModel> Emprestimos { get; set; }

    }
}
