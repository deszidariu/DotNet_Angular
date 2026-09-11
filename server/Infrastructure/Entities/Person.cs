namespace Infrastructure.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string Picture { get; set; }
        public ICollection<Card>? Cards { get; set; }
    }
}