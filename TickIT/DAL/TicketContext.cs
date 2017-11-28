using System.Data.Entity;
using TickIT.Models;

namespace TickIT.DAL
{
    public class TicketContext : DbContext
    {

        public TicketContext() : base("TicketContext")
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
    }
}