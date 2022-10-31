namespace mille_et_une_nuit_creation.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Articles { get; set; }
    }
}
