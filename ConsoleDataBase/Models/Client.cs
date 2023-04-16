namespace ConsoleDataBase.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public virtual Project Project { get; set; }
    }
}
