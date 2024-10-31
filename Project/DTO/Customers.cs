namespace Project.DTO
{
    public class Customers
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string KindComputer { get; set; }
        public Customers()
        {
            
        }

        public Customers(string name, string phone, string email, string city, string kindComputer, int id)
        {
            Name = name;
            Phone = phone;
            Email = email;
            City = city;
            KindComputer = kindComputer;
            Id = id;
        }
    }
}
