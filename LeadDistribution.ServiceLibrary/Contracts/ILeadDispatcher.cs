using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public interface ILeadDispatcher
    {
        /// <summary>
        /// Gets or sets the agent scheduler.
        /// </summary>
        /// <value>
        /// The agent scheduler.
        /// </value>
        IAgentScheduler AgentScheduler { get; set; }

        /// <summary>
        /// Initializes the agent scheduler.
        /// </summary>
        /// <param name="agentScheduler">The agent scheduler.</param>
        void InitializeAgentScheduler(IAgentScheduler agentScheduler);

        /// <summary>
        /// Dispatches the specified lead to agent scheduler.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <returns></returns>
        IAgentDTO Dispatch(ILeadDTO leadDetails);

    }
}
