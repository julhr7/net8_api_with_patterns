using System;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public string ProductTypeName { get; set; }
        public long NumeracioTerminal { get; set; } 
        public DateTime SoldAt { get; set; }
        public string CustomerId { get; set; }
    }
}
