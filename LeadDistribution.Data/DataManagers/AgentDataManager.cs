using System.Linq;
using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.Data
{
    /// <summary>
    /// The data manager class for agent information
    /// </summary>
    public class AgentDataManager : IAgentDataManager
    {
        /// <summary>
        /// Adds the agent for territory.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        public void AddAgent(IAgentDTO agentDetails)
        {
            ApplicationDataStore.TerritoryAgentDictionary[agentDetails.Territory].AddNode(agentDetails);
        }

        /// <summary>
        /// Removes the agent.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        /// <returns></returns>
        public bool RemoveAgent(IAgentDTO agentDetails)
        {
            return ApplicationDataStore.TerritoryAgentDictionary[agentDetails.Territory].RemoveNode(agentDetails);
        }

        /// <summary>
        /// Gets the agents container iterator.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <returns></returns>
        public INodeContainerIterator<IAgentDTO> GetAgentsContainerIterator(ILeadDTO leadDetails)
        {
            return ApplicationDataStore.TerritoryAgentDictionary[leadDetails.Territory];
        }

        /// <summary>
        /// Assigns the lead to agent.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <param name="agentDTO">The agent DTO.</param>
        public void AssignLeadToAgent(ILeadDTO leadDetails, IAgentDTO agentDTO)
        {
            ApplicationDataStore.LeadAgentDictionary.Add(leadDetails.ID, agentDTO);
        }

        /// <summary>
        /// Determines whether [is lead associated with agent].
        /// </summary>
        /// <param name="leadID">The lead ID.</param>
        /// <returns>
        ///   <c>true</c> if [is lead associated with agent]; otherwise, <c>false</c>.
        /// </returns>
        public bool IsLeadAssociatedWithAgent(int leadID)
        {
            return ApplicationDataStore.LeadAgentDictionary.ContainsKey(leadID);
        }
    }
}
