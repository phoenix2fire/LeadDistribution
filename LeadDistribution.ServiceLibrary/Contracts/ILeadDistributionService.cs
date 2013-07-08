using System.ServiceModel;
using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.ServiceLibrary
{
    /// <summary>
    /// Service Contract for Lead Distribution Service
    /// </summary>
    [ServiceContract]
    public interface ILeadDistributionService
    {
        /// <summary>
        /// Process the lead details provided.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <returns></returns>
        [OperationContract]
        [ServiceKnownType(typeof(LeadDTO))]
        [ServiceKnownType(typeof(AgentDTO))]
        OperationResult<IAgentDTO> ProcessLead(ILeadDTO leadDetails);

        /// <summary>
        /// Adds the agent to a territory.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        [OperationContract]
        [ServiceKnownType(typeof(AgentDTO))]
        void AddAgent(IAgentDTO agentDetails);

        /// <summary>
        /// Removes the agent.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        /// <returns></returns>
        [OperationContract]
        [ServiceKnownType(typeof(AgentDTO))]
        bool RemoveAgent(IAgentDTO agentDetails);

        /// <summary>
        /// Adds the territory data.
        /// </summary>
        /// <param name="territoryData">The territory data.</param>
        [OperationContract]
        [ServiceKnownType(typeof(TerritoryDTO))]
        void AddTerritoryData(ITerritoryDTO territoryData);

        /// <summary>
        /// Cleans the data store.
        /// </summary>
        [OperationContract]
        void CleanDataStore();
    }
}
