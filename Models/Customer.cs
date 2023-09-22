using System.ComponentModel.DataAnnotations;

namespace MediatRCQRSDemo.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int CustomerNumber { get; set; }

        [StringLength(20)]
        [Required]
        public string FullName { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        [StringLength(15)]
        [Required]
        public string Mobile { get; set; }
    }
}
