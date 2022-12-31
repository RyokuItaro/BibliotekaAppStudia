using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Db
{
    public interface IConfigRepository
    {
        public string GetConfigValueByKey(string key);
    }
}
