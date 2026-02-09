using EventCore.Entities;

namespace EventCore.Interfaces;

public interface IEventRepository
{
    public IEnumerable<Event> GetAll();
    public void Add(Event e);
}