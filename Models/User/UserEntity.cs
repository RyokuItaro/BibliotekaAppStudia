using BibliotekaMVCApp.Models.Post;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BibliotekaMVCApp.Models.User
{
    public class UserEntity : IdentityUser
    {
        public string VisibleName { get; set; }
        public Role Role { get; set; }
        public Status Status { get; set; }
        public List<PostEntity> Posts { get; set; }
    }
}
