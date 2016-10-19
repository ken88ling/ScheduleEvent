using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScheduleEvent.Models
{
    public class ScheduleDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }

        public ScheduleDbContext(DbContextOptions<ScheduleDbContext> options) : base(options)
        {

        }
    }
}
