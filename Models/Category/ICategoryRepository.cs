using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Category
{
    public interface ICategoryRepository
    {
        public CategoryEntity GetCategoryById(Guid categoryId);
    }
}
