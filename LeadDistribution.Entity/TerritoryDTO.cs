
using System.Runtime.Serialization;
namespace TTX.LeadDistribution.DTO
{
    [DataContract]
    public class TerritoryDTO: ITerritoryDTO
    {
        /// <summary>
        /// Gets or sets the ID.
        /// </summary>
        /// <value>
        /// The ID.
        /// </value>
        [DataMember]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        /// <value>
        /// The Name.
        /// </value>
        [DataMember]
        public string Name { get; set; }
    }
}
