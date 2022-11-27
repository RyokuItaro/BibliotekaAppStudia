using BibliotekaMVCApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Post
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<PostEntity> GetAllPosts()
        {
            return _appDbContext.Posts.ToList();
        }

        public void CreateMockPostEntities(PostEntity postEntity)
        {
            _appDbContext.Posts.Add(postEntity);
            _appDbContext.SaveChanges();
        }
    }
}
