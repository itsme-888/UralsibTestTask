using Microsoft.EntityFrameworkCore;
using UralsibTestTask.Models;

namespace UralsibTestTask
{
    public class DataContext :DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientInfo> ClientsInfo { get; set; }
        public DbSet<Buy> Buys { get; set; }

        public DataContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ClientAndBuys;Trusted_Connection=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientInfo>().HasData(
                new ClientInfo { Email = "www@yar.ru", ClientInfoId = 1, BirthDay = DateTime.Now.AddYears(-20), Phone = "8(999)334-34-34" },
                new ClientInfo { Email = "wdfdfdfd@gg.ru", ClientInfoId = 2, BirthDay = DateTime.Now.AddYears(-25).AddMonths(-3), Phone = "8(934)311-74-31" }
               );

            modelBuilder.Entity<Client>().HasData(
                new Client { ClientId = 1, Name = "Иван",Surname= "Иванов", Patronymic= "Иванович", ClientInfoId = 1 },
                new Client { ClientId = 2, Name = "Андрей", Surname= "Петров", Patronymic ="Александрович", ClientInfoId = 2 }
                );
        }
    }
}
