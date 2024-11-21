namespace FilmAndMovie.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoUrl { get; set; }

        public Genre genre { get; set; }
    }
    public enum Genre
    {
        Horror,
        Action,
        Comedy,
        Romatic
    }
}
