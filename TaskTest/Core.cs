namespace TaskTest
{
   
    public class Library
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public IList<Book> Books { get; set; }
    }
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int LibraryId { get; set; }
    }
    public class ResultModel
    {
        public bool IsSuccess { get; set; } = true;
        public int Result { get; set; } = 1;
        public List<string> Message { get; set; }
        public string Remark { get; set; }
    }
}
