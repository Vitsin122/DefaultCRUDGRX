namespace DefaultCRUDGRX.DAL.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Status_ID { get; set; }
        public Status? Status { get; set; }
    }
}
