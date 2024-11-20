namespace ManageLibrary.Models
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Member> Members { get; set; } = new List<Member>();

        public void AddBook(Book book)
        {
            Books?.Add(book);
        }

        public void RegisterMember(Member member)
        {
            Members?.Add(member);
        }

        // Cho thành viên mượn sách
        public bool LendBook(string bookId, string memberId)
        {
            var book = Books.FirstOrDefault(b => b.ID == bookId);
            var member = Members.FirstOrDefault(m => m.ID == memberId);

            if (book != null && member != null)
            {
                return member.BorrowBook(book);
            }

            return false;
        }

        public void ReturnBook(string bookId, string memberId)
        {
            var book = Books.FirstOrDefault(b => b.ID == bookId);
            var member = Members.FirstOrDefault(m => m.ID == memberId);

            if (book != null && member != null)
            {
                member.ReturnBook(book);
            }
        }
    }
}
