namespace Infrastructure.Entities
{
    public class Card
    {
        public int Id { get; set; }
        public required string CardNumber { get; set; }
        public required string CardholderName { get; set; }
        public required string ExpirationDate { get; set; }
        public required string CVV { get; set; }
        public required string CardType { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUsedDate { get; set; }
        public int PersonId { get; set; }
        public Person? Person { get; set; }
    }
}