using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SQLNET.Data.Models;

namespace SQLNET.Data
{
    class ApplicationDbContext : DbContext
    {
        public DbSet<Suppliers> Поставщики { get; set; }
        public DbSet<Categories> Категории { get; set; }
        public DbSet<Products> Товары { get; set; }
        public DbSet<Rating> Оценки { get; set; }
        public DbSet<Employees> Сотрудники { get; set; }
        public DbSet<Clients> Клиенты { get; set; }
        public DbSet<Order> Заказы { get; set; }
        public DbSet<Elements_order> Элементы_заказа { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=NEKO;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
