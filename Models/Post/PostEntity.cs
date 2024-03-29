﻿using BibliotekaMVCApp.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Post
{
    public class PostEntity
    {
        [Key]
        public Guid PostId { get; set; }
        [Display(Name = "Tytuł")]
        [Required(ErrorMessage = "Należy podać tytuł posta")]
        public string Title { get; set; }
        [Display(Name = "Treść")]
        [Required(ErrorMessage = "Należy wprowadzić treść posta")]
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public UserEntity User { get; set; }
    }
}
