using _Viagens.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _Viagens.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Feedback> Feedbacks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JVPNAB2;Initial Catalog=MonitoriaMVC;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feedback>(t =>
            {
                t.ToTable("Feeddback");
                t.HasKey(p => p.Id_feedback);
                t.Property(p => p.Data).HasColumnType("DATE").IsRequired();
                t.Property(p => p.Descricao).HasMaxLength(300).IsRequired();
            });
        }
    }
}
