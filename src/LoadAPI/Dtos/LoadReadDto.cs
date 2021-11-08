namespace LoadAPI.Dtos
{
    public class LoadReadDto
    {
        public int Id{get;set;}
        public string LoadNumber { get; set; }
        public string Broker { get; set; }
        public string PickUpAddress { get; set; }
        public string DeliveryAddress { get; set; }
    }
}