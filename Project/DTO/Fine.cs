namespace Project.DTO
{
    public class Fine
    {
        public int IdFine { get; set; }
        public int IdCustomer { get; set; }
        public int IdComputer { get; set; }
        public int Price { get; set; }
        public DateTime DateFine { get; set; }
        public int StatusPay { get; set; }
        public string ResonOfFine { get; set; }
        public Fine()
        {
                
        }

        public Fine(int idFine, int idCustomer, int idComputer, int price, DateTime dateFine, int statusPay, string resonOfFine)
        {
            IdFine = idFine;
            IdCustomer = idCustomer;
            IdComputer = idComputer;
            Price = price;
            DateFine = dateFine;
            StatusPay = statusPay;
            ResonOfFine = resonOfFine;
        }
    }
}
