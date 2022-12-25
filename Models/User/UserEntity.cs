using BibliotekaMVCApp.Models.BorrowCart;
using BibliotekaMVCApp.Models.Post;
using BibliotekaMVCApp.Models.Queue;
using BibliotekaMVCApp.Models.Ticket;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.User
{
    public class UserEntity : IdentityUser
    {
        public string VisibleName { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
        public List<BorrowCart.BorrowCart> BorrowCarts { get; set; }
        public List<PostEntity> Posts { get; set; }
        public List<QueueEntity> Queues { get; set; }
        public List<TicketEntity> Tickets { get; set; }
    }
}
