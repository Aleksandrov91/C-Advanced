using System.Xml.Serialization;

namespace PetClinic.DataProcessor.ExportDtos
{
    [XmlType("AnimalAid")]
    public class AnimalAidDto
    {
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}
