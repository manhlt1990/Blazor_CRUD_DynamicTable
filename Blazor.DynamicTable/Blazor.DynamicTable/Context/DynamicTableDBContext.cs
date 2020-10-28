using Blazor.DynamicTable.Constants;
using Blazor.DynamicTable.Extensions;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.DynamicTable.Context
{
    public class DynamicTableDBContext : DbContext
    {
        public DynamicTableDBContext()
        {
        }

        public DynamicTableDBContext(DbContextOptions<DynamicTableDBContext> options)
            : base(options)
        {
        }

        public DbSet<DynamicTable> DynamicTables { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
