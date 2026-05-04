using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324261675.Models;

namespace ValeAtivos324261675.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

        public DbSet<Equipamento> CaracteristicasEquipamentos {get; set;}
        
    }
}