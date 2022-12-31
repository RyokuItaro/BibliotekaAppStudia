using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Db
{
    public class Config
    {
        [Key]
        public Guid ConfigId { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
