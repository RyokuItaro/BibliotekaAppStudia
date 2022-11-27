using BibliotekaMVCApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Tag
{
    public class TagRepository : ITagRepository
    {
        private readonly AppDbContext appDbContext;

        public TagRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public TagEntity GetTagById(Guid tagId)
        {
            return appDbContext.Tags.FirstOrDefault(tag => tag.TagId == tagId);
        }
    }
}
