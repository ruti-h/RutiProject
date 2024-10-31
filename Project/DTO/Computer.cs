namespace Project.DTO
{
    public class Computer
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Destination { get; set; }
        public int Price { get; set; }
        public int DorComputer { get; set; }
        public Computer()
        {
            
        }

        public Computer(int id, string company, string destination, int price, int dorComputer)
        {
            Id = id;
            Company = company;
            Destination = destination;
            Price = price;
            DorComputer = dorComputer;
        }
    }
}
