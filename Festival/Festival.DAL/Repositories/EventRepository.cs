using Festival.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Festival.DAL.Data;

namespace Festival.DAL.Repositories
{
    public class EventRepository
    {
        private readonly FestivalDbContext _context;

        public EventRepository(FestivalDbContext context)
        {
            _context = context;
        }

        // Get all events
        public List<Event> GetAllEvents()
        {
            return _context.Events.ToList();
        }

        // Get event by ID
        public Event GetEventById(int id)
        {
            return _context.Events.Find(id);
        }

        // Add a new event
        public void AddEvent(Event eventObj) // Renamed from 'event' to 'eventObj'
        {
            _context.Events.Add(eventObj);
            _context.SaveChanges();
        }

        // Update an existing event
        public void UpdateEvent(Event eventObj) // Renamed from 'event' to 'eventObj'
        {
            _context.Entry(eventObj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete an event
        public void DeleteEvent(int id)
        {
            var eventObj = _context.Events.Find(id); // Renamed from 'event' to 'eventObj'
            if (eventObj != null)
            {
                _context.Events.Remove(eventObj);
                _context.SaveChanges();
            }
        }
    }
}