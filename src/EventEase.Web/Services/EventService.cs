using EventEase.Web.Models;

namespace EventEase.Web.Services;

public class EventService
{
    private List<EventModel> events = new();

    public List<EventModel> GetAll() => events;

    public void Add(EventModel ev) => events.Add(ev);

    public void Update(EventModel updated)
    {
        var index = events.FindIndex(e => e.Id == updated.Id);
        if (index != -1) events[index] = updated;
    }

    public void Delete(Guid id)
    {
        var ev = events.FirstOrDefault(e => e.Id == id);
        if (ev != null) events.Remove(ev);
    }
}
