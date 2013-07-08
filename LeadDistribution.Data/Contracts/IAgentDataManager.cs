using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.Data
{
    public interface IAgentDataManager
    {
        /// <summary>
        /// Adds the agent for territory.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        void AddAgent(IAgentDTO agentDetails);

        /// <summary>
        /// Removes the agent.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        /// <returns></returns>
        bool RemoveAgent(IAgentDTO agentDetails);

        /// <summary>
        /// Gets the agents container iterator.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <returns></returns>
        INodeContainerIterator<IAgentDTO> GetAgentsContainerIterator(ILeadDTO leadDetails);

        /// <summary>
        /// Assigns the lead to agent.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <param name="agentDTO">The agent DTO.</param>
        void AssignLeadToAgent(ILeadDTO leadDetails, IAgentDTO agentDTO);

        /// <summary>
        /// Determines whether [is lead associated with agent].
        /// </summary>
        /// <param name="leadID">The lead ID.</param>
        /// <returns>
        ///   <c>true</c> if [is lead associated with agent]; otherwise, <c>false</c>.
        /// </returns>
        bool IsLeadAssociatedWithAgent(int leadID);
    }
}
