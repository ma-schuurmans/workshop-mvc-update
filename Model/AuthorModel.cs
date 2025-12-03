namespace MVC_Update.Model
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AuthorModel(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
