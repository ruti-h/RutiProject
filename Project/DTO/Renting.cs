namespace Project.DTO
{
    public class Renting
    {
        public int IdComputer { get; set; }
        public int IdCustomer { get; set; }
        public int IdRenting { get; set; }
        public DateTime DateRenting { get; set; }
        public bool Status { get; set; }
        public Renting()
        {
            
        }

        public Renting(int idComputer, int idCustomer, int idRenting, DateTime dateRenting, bool status)
        {
            IdComputer = idComputer;
            IdCustomer = idCustomer;
            IdRenting = idRenting;
            DateRenting = dateRenting;
            Status = status;
        }
    }
}
