using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models
{
    public class UserEntity : IdentityUser
    {
        public string VisibleName { get; set; }
    }
}
