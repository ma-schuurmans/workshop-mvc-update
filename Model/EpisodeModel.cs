namespace MVC_Update.Model
{
    public class EpisodeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public AuthorModel Author { get; set; }

        public EpisodeModel(int id, string title, DateOnly date, AuthorModel author)
        {
            Id = id;
            Title = title;
            Date = date;
            Author = author;
        }
    }
}
