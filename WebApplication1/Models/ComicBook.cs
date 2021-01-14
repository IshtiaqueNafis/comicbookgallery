namespace WebApplication1.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; } // this will have html based strings
        public Artists[] Artists { get; set; }
        public bool Favorite { get; set; }
  
        public string DisplayText => $"{SeriesTitle} # {IssueNumber}"; 
        public string CoverImageFileName => $"{SeriesTitle.Replace(" ", "-").ToLower()}-{IssueNumber}.jpg";
    }
}