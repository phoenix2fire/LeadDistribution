using TTX.LeadDistribution.Data;
using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.ServiceLibrary
{
    /// <summary>
    /// Last In First Out Scheduler
    /// </summary>
    public class LIFOAgentScheduler: IAgentScheduler
    {
        #region Public Methods
        /// <summary>
        /// Schedules an agent using agent container iterator
        /// </summary>
        /// <param name="leadDetails">The lead to be given to an agent.</param>
        /// <param name="agentContainerIterator">Agent Container iterator.</param>
        /// <returns></returns>
        public IAgentDTO ScheduleAgent(ILeadDTO leadDetails, INodeContainerIterator<IAgentDTO> agentContainerIterator)
        {
            IAgentDTO assignedAgent = null;
            if (agentContainerIterator.HasNodes())
            {
                ///Fetch the next available node
                assignedAgent = agentContainerIterator.PeekCurrent();
                ///Assign lead to the agent in Datastore
                IAgentDataManager agentDataManager = new LeadDistributionDataFactory().GetAgentDataManager(DataComponentType.InMemoryData);
                agentDataManager.AssignLeadToAgent(leadDetails, assignedAgent);
                ///Move the iterator to the next node.
                agentContainerIterator.MoveNext();
            }
            return assignedAgent;
        }

        #endregion
    }
}
