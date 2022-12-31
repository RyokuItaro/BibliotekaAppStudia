using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Db
{
    public class ConfigRepository : IConfigRepository
    {
        private readonly AppDbContext _appDbContext;

        public ConfigRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string GetConfigValueByKey(string key)
        {
            var configLine = _appDbContext.Config
                .FirstOrDefault(c => c.Key.ToLower() == key.ToLower());

            return configLine != null ? configLine.Value : String.Empty;
        }
    }
}
