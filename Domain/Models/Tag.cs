namespace Domain.Models
{
    public class Tag: BaseModel
    {
        public string Name { get; set; }
        public int ComicsId { get; set; }
        public Comics Comics { get; set; }
    }
}
