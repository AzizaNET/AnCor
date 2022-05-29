namespace AncorAPI.Models
{
    public class Transfer
    {
        public int Id { get; set; }
        public decimal DebtAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public decimal Balance { get; set; }
        public string MFO { get; set; }

    }
}
