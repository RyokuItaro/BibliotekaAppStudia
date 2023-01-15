using BibliotekaMVCApp.Helpers;
using BibliotekaMVCApp.Models.BorrowCartItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekaMVCApp.ViewModels
{
    public class BorrowedBooksViewModel
    {
        public PaginatedList<BorrowCartItemEntity> BorrowedBooks { get; set; }
    }
}
