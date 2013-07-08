using System.Runtime.Serialization;

namespace TTX.LeadDistribution.DTO
{
    /// <summary>
    /// Data Transfer class for Lead information
    /// </summary>
    [DataContract]
    public class LeadDTO: ILeadDTO
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
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the territory.
        /// </summary>
        /// <value>
        /// The territory.
        /// </value>
        [DataMember]
        public string Territory { get; set; }

        /// <summary>
        /// Gets or sets the interest.
        /// </summary>
        /// <value>
        /// The interest.
        /// </value>
        [DataMember]
        public string Interest { get; set; }
    }
}
