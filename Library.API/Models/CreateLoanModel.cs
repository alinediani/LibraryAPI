namespace Library.API.Models
{
    public class LoanModel
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdBook { get; set; }
        public string Date { get; set; }
        public string Email { get; set; }
    }
}
