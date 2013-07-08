using System.Runtime.Serialization;

namespace TTX.LeadDistribution.DTO
{
    /// <summary>
    /// Data Transfer class for Agent information
    /// </summary>
    [DataContract]
    public class AgentDTO: IAgentDTO
    {
        /// <summary>
        /// Gets or sets the agent ID.
        /// </summary>
        /// <value>
        /// The agent ID.
        /// </value>
        /// </exception>
        [DataMember]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the agent name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the territory ID.
        /// </summary>
        /// <value>
        /// The territory ID.
        /// </value>
        [DataMember]
        public string Territory { get; set; }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="otherDTO">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object otherDTO)
        {
            return this.ID.Equals(((AgentDTO)otherDTO).ID);
        }
    }
}
