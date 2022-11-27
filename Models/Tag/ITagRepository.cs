using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Tag
{
    public interface ITagRepository
    {
        public TagEntity GetTagById(Guid tagId);
    }
}
