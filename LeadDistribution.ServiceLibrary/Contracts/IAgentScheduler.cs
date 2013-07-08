using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public interface IAgentScheduler
    {
        /// <summary>
        /// Schedules an agent using agent container iterator
        /// </summary>
        /// <param name="leadDetails">The lead to be given to an agent.</param>
        /// <param name="agentCollection">The agent collection.</param>
        /// <returns></returns>
        IAgentDTO ScheduleAgent(ILeadDTO leadDetails, INodeContainerIterator<IAgentDTO> agentCollection);

    }
}
