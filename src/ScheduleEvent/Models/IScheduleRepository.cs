using System.Collections.Generic;
using System.Threading.Tasks;

namespace ScheduleEvent.Models
{
    public interface IScheduleRepository
    {
        Task Add(Event item);
        Task<IEnumerable<Event>> GetAll();
        Task<Event> Find(int eventId);
        void Remove(int eventId);
        Task Update(Event item);
    }
}
