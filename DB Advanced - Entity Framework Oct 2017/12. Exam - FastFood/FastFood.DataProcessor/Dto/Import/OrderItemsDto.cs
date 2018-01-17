using System.Xml.Serialization;

namespace FastFood.DataProcessor.Dto.Import
{
    [XmlType("Item")]
    public class OrderItemsDto
    {
        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}