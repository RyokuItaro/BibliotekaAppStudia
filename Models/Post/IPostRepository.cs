using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.Post
{
    public interface IPostRepository
    {
        public List<PostEntity> GetAllPosts();
        public void CreateMockPostEntities(PostEntity postEntity);
    }
}
