namespace ManageLibrary.Models
{
    public class Member
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public List<Book> BorrowedBooks { get; set; } = new List<Book>();

        public bool BorrowBook(Book book)
        {
            if (book.IsBorrowed)
            {
                return false;
            }
            if (BorrowedBooks?.Count >= 5)
            { // Giới hạn mượn sách là 5
                return false;
            }
            book.Borrow();
            BorrowedBooks?.Add(book);
            return true;
        }
        public void ReturnBook(Book book)
        {
            // Find the book in the BorrowedBooks list
            var bookToRemove = BorrowedBooks?.FirstOrDefault(x => x.ID == book.ID);

            // If the book is found, remove it
            if (bookToRemove != null)
            {
                BorrowedBooks?.Remove(bookToRemove);
                return;
            }
            return;
        }
    }
}
