using Project.DTO;

namespace Project.Servies
{
    public class CustomersServies
    {
        static List<Customers> customersList = new List<Customers>() { new Customers()
        { Name="Rachel",Phone="0548428867",Id=1,KindComputer="Programing",City="jerusalem",Email="r55@gmail.com"} };
        public List<Customers> CustomersList()  { return customersList; } 

    }
}
