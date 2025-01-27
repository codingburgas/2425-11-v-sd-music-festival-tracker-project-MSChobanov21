using Festival.DAL.Repositories;
using Festival.DAL.Models;
using System.Collections.Generic;

namespace Festival.BLL
{
    public class TicketService
    {
        private readonly TicketRepository _ticketRepository;

        // Constructor: Inject the TicketRepository
        public TicketService(TicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        // Get all tickets
        public List<Ticket> GetAllTickets()
        {
            return _ticketRepository.GetAllTickets();
        }

        // Get ticket by ID
        public Ticket GetTicketById(int id)
        {
            return _ticketRepository.GetTicketById(id);
        }

        // Add a new ticket
        public void AddTicket(Ticket ticket)
        {
            // Add business logic here (e.g., validation)
            _ticketRepository.AddTicket(ticket);
        }

        // Update an existing ticket
        public void UpdateTicket(Ticket ticket)
        {
            // Add business logic here (e.g., validation)
            _ticketRepository.UpdateTicket(ticket);
        }

        // Delete a ticket
        public void DeleteTicket(int id)
        {
            // Add business logic here (e.g., check if the ticket exists)
            _ticketRepository.DeleteTicket(id);
        }
    }
}