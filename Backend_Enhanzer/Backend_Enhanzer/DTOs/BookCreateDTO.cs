namespace Backend_Enhanzer.DTOs
{
    public class BookCreateDTO
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string? ISBN { get; set; }
        public DateTime PublicationDate { get; set; }
    }

    public class BookUpdateDTO : BookCreateDTO { }
}
