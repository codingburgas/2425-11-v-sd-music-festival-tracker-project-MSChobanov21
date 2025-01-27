using System;

namespace Festival.DAL.Models
{
    public class Ticket
    {
        // Unique identifier for the ticket
        public int Id { get; set; }

        // Foreign key to associate the ticket with an event
        public int EventId { get; set; }

        // Price of the ticket
        public decimal Price { get; set; }

        // Date and time when the ticket was purchased
        public DateTime PurchaseDate { get; set; }

        // Name of the customer who purchased the ticket
        public string CustomerName { get; set; }

        // Navigation property to the associated event
        public Event Event { get; set; }
    }
}