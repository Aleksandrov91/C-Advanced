namespace Stations.DataProcessor.Dto
{
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Stations.Models.Enums;

    public class TrainDto
    {
        public TrainDto()
        {
            this.TrainSeats = new List<TrainSeatDto>();
        }

        public string TrainNumber { get; set; }

        public TrainType? Type { get; set; }

        [JsonProperty("Seats")]
        public ICollection<TrainSeatDto> TrainSeats { get; set; }
    }
}
