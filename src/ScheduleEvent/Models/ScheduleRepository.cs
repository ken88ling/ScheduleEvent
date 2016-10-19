using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ScheduleEvent.Models
{
   
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ScheduleDbContext _context;


        public ScheduleRepository(ScheduleDbContext context)
        {
            _context = context;
        }
        public async void Add(Event item)
        {
            _context.Events.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _context.Events.ToListAsync();
        }

        public async Task<Event> Find(int eventId)
        {
            return await _context.Events.FirstOrDefaultAsync(x => x.EventId == eventId);
        }

        public async Task<Event> Remove(int eventId)
        {
            return await _context.Events.FirstOrDefaultAsync(x => x.EventId == eventId);
        }

        public async Task Update(Event item)
        {
            _context.Events.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
