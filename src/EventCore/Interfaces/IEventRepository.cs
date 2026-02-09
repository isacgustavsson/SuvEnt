using EventCore.Entities;

namespace EventCore.Interfaces;

public interface IEventRepository
{
    public void Add(Event e);
}