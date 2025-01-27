using Festival.DAL.Repositories;
using Festival.DAL.Models;
using System.Collections.Generic;

namespace Festival.BLL
{
    public class EventService
    {
        private readonly EventRepository _eventRepository;

        // Constructor: Inject the EventRepository
        public EventService(EventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        // Get all events
        public List<Event> GetAllEvents()
        {
            return _eventRepository.GetAllEvents();
        }

        // Get event by ID
        public Event GetEventById(int id)
        {
            return _eventRepository.GetEventById(id);
        }

        // Add a new event
        public void AddEvent(Event eventObj)
        {
            // Add business logic here (e.g., validation)
            _eventRepository.AddEvent(eventObj);
        }

        // Update an existing event
        public void UpdateEvent(Event eventObj)
        {
            // Add business logic here (e.g., validation)
            _eventRepository.UpdateEvent(eventObj);
        }

        // Delete an event
        public void DeleteEvent(int id)
        {
            // Add business logic here (e.g., check if the event exists)
            _eventRepository.DeleteEvent(id);
        }
    }
}