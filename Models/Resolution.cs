namespace ELECTIVE_H1_BSIT_32E2_DOLLENTE_BIANCA.Models
{
    public class Resolution
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
