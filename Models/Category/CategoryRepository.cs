using BibliotekaMVCApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Category
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public CategoryEntity GetCategoryById(Guid categoryId)
        {
            return appDbContext.Categories.FirstOrDefault(category => category.CategoryId == categoryId);
        }
    }
}
