using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Prime.Models;

namespace Prime.Context
{
    public class TodoContext : DbContext
    {
    
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

        public DbSet<ClientePessoaFisica> ClientePessoaFisica {get; set;}
        public DbSet<ClientePessoaJuridica> ClientePessoaJuridica {get; set;}

        public void Save()
        {
            base.SaveChanges();
        }
    }
}