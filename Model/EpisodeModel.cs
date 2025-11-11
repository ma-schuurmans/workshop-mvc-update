namespace MVC_Update.Model
{
    public class EpisodeModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public int AuthorId { get; set; }

        public EpisodeModel(int id, string title, DateOnly date, int authorId)
        {
            Id = id;
            Title = title;
            Date = date;
            AuthorId = authorId;
        }
    }
}
