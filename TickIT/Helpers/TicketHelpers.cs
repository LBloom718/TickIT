using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TickIT.Models;

namespace TickIT.Helpers
{
    public static class TicketHelpers
    {

        public static int CountOpenTickets(User user)
        {
            var open = 0;

            var openTickets = user.Tickets;
            foreach (var item in openTickets)
            {
                if (item.status.Equals(Status.OPEN))
                {
                    open += 1;
                }
            }
            return open;
        }











    }
}