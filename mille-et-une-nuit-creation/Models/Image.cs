namespace mille_et_une_nuit_creation.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string url { get; set; }
        public Article Article { get; set; }
    }
}
