namespace BibliotekaMVCApp.Models.BorrowCartItem
{
    public enum Status
    {
        Returned,
        Cancelled,
        Waiting,
        Borrowed,
        NotConfirmedByUser,
        NotConfirmedByEmployee
    }
}