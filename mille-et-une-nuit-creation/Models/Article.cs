namespace mille_et_une_nuit_creation.Models 
{
    public class Article
    {
        
        public int Id { get; set; }

        public string Title { get; set; }
        public int Qty { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Dimension { get; set; }
        public string Matiere { get; set; }
        public Category Category { get; set; }
        public ICollection<Image> Image { get; set; }

    }
}
