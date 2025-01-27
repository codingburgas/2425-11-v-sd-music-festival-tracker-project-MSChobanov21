using Festival.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Festival.DAL.Data;

namespace Festival.DAL.Repositories
{
    public class TicketRepository
    {
        private readonly FestivalDbContext _context;

        public TicketRepository(FestivalDbContext context)
        {
            _context = context;
        }

        // Get all tickets
        public List<Ticket> GetAllTickets()
        {
            return _context.Tickets.ToList();
        }

        // Get ticket by ID
        public Ticket GetTicketById(int id)
        {
            return _context.Tickets.Find(id);
        }

        // Add a new ticket
        public void AddTicket(Ticket ticket)
        {
            _context.Tickets.Add(ticket);
            _context.SaveChanges();
        }

        // Update an existing ticket
        public void UpdateTicket(Ticket ticket)
        {
            _context.Entry(ticket).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete a ticket
        public void DeleteTicket(int id)
        {
            var ticket = _context.Tickets.Find(id);
            if (ticket != null)
            {
                _context.Tickets.Remove(ticket);
                _context.SaveChanges();
            }
        }
    }
}