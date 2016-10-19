using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleEvent.Models
{
    public interface IScheduleRepository
    {
        void Add(Event item);
        Task<IEnumerable<Event>> GetAll();
        Task<Event> Find(int eventId);
        Task<Event> Remove(int eventId);
        Task Update(Event item);
    }
}