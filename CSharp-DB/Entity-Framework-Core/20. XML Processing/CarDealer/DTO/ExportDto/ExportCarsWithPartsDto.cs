namespace CarDealer.DTO.ExportDto
{
    using System.Xml.Serialization;
    
    [XmlType("part")]
   public class ExportCarsWithPartsDto
    {
        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("price")]
        public decimal Price { get; set; }
    }
}
