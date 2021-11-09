using System.ComponentModel.DataAnnotations;

namespace LoadAPI.Dtos
{
    public class LoadUpdateDto
    {
        [Required]
        [MaxLength(500)]
        public string LoadNumber { get; set; }
        [Required]
        public string Broker { get; set; }
        [Required]
        public string PickUpAddress { get; set; }
        [Required]
        public string DeliveryAddress { get; set; }
    }
}