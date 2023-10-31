
namespace CleanArch.Domain.Model;

    public class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Address { get; set; }
    }
