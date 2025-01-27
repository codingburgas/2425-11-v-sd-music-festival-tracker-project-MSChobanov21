using System;

namespace Festival.DAL.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        
        public int EventId { get; set; }
        
        public decimal Price { get; set; }

        public DateTime PurchaseDate { get; set; }

        public string CustomerName { get; set; }

        public Event Event { get; set; }
    }
}