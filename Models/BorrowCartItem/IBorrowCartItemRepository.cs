using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.Models.BorrowCartItem
{
    public interface IBorrowCartItemRepository
    {
        public List<BorrowCartItemEntity> GetBorrowedBooks();
        public List<BorrowCartItemEntity> GetBorrowedBooks(string userId);
    }
}
