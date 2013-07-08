
namespace TTX.LeadDistribution.DTO
{
    /// <summary>
    /// Data transfer contract for Agent information
    /// </summary>
    public interface IAgentDTO
    {
        /// <summary>
        /// Gets or sets the agent ID.
        /// </summary>
        /// <value>
        /// The agent ID.
        /// </value>
        /// </exception>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the agent name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the territory ID.
        /// </summary>
        /// <value>
        /// The territory ID.
        /// </value>
        string Territory { get; set; }
    }
}
