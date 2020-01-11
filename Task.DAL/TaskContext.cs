using Microsoft.EntityFrameworkCore;
using System;
using Task.DAL.Entities;

namespace Task.DAL
{
    public class TaskContext: DbContext
    {
        /// <summary>
        /// DBSet our Entities
        /// </summary>
        public DbSet <Item> Items { get; set; }

        /// <summary>
        /// Conection String to DB
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=itemsbase.db");
    }
}
