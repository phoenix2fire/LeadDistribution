using TTX.LeadDistribution.Data;
using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public class TerritoryDispatcher : ILeadDispatcher
    {
        
        #region Public Members
        /// <summary>
        /// Gets or sets the agent scheduler.
        /// </summary>
        /// <value>
        /// The agent scheduler.
        /// </value>
        public IAgentScheduler AgentScheduler { get; set; }

        #endregion

        #region Public Methods
        /// <summary>
        /// Initializes the agent-scheduler.
        /// </summary>
        /// <param name="agentScheduler">The agent scheduler.</param>
        public void InitializeAgentScheduler(IAgentScheduler agentScheduler)
        {
            this.AgentScheduler = agentScheduler;
        }

        /// <summary>
        /// Dispatches the specified lead to agent scheduler.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        public IAgentDTO Dispatch(ILeadDTO leadDetails)
        {
            IAgentDataManager agentDataManager = new LeadDistributionDataFactory().GetAgentDataManager(DataComponentType.InMemoryData);
            ///Get the agent container for given territory using lead details
            INodeContainerIterator<IAgentDTO> agentContainerIterator = agentDataManager.GetAgentsContainerIterator(leadDetails);
            ///Schedule an agent using the agent container iterator
            return this.AgentScheduler.ScheduleAgent(leadDetails, agentContainerIterator);
        }

        #endregion
    }
}
