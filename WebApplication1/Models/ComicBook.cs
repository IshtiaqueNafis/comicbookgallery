namespace WebApplication1.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHTML { get; set; } // this will have html based strings
        public Artists[] Artists { get; set; }
        public bool Favourite { get; set; }
    }
}