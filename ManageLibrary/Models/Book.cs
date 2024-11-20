namespace ManageLibrary.Models
{
    public class Book
    {
        public string? ID { get; set; }

        public string? Title { get; set; }

        public string? Author { get; set; }

        public bool IsBorrowed { get; set; }

        public void Borrow()
        {
            IsBorrowed = true;
        }
        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
