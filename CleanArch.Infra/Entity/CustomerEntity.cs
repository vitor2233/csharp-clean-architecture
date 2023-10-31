using System.ComponentModel.DataAnnotations.Schema;

namespace CleanArch.Infra.Entity;

    [Table("T_CUSTOMER")]
    public class CustomerEntity
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column("NAME")]
        public required string Name { get; set; }
        [Column("ADDRESS")]
        public required string Address { get; set; }
    }
