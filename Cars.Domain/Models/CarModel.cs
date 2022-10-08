namespace Cars.Domain.Models
{
    public class CarModel
    {
        public string Name { get; set; }
        public int EngineType { get; set; }
        public int EnginePower { get; set; }
        public float EngineVolume { get; set; }
        public string BodyType { get; set; }
        public string TransmissionType { get; set; }
        public decimal Price { get; set; }
    }
}
