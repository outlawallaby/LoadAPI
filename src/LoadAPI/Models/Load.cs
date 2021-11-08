using System.ComponentModel.DataAnnotations;

namespace LoadAPI.Models
{
    public class Load
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string LoadNumber { get; set; }
        [Required]
        public string Broker { get; set; }
        [Required]
        public string PickUpAddress { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
    }

}