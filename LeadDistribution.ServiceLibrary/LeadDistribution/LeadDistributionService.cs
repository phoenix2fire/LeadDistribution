using TTX.LeadDistribution.Data;
using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.ServiceLibrary
{
    /// <summary>
    /// Lead Distribution Service contract implementation
    /// </summary>
    public class LeadDistributionService : ILeadDistributionService
    {
        #region Constants
        private const string AgentAssigned = "Agent assigned to the lead.";
        private const string AgentNotAssigned = "Agents not avaliable.";
        #endregion

        #region Public Methods
        /// <summary>
        /// Process the lead details provided.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        /// <returns></returns>
        public OperationResult<IAgentDTO> ProcessLead(ILeadDTO leadDetails)
        {
            IAgentDTO assignedAgent = null;
            LeadDistributionFactory leadDistributionFactory = new LeadDistributionFactory();
            IValidateLead validateLead = leadDistributionFactory.GetLeadValidator(LeadValidatorType.ValidateTerritory);
            ///Validate the lead
            validateLead.Validate(leadDetails);

            if (validateLead.IsValid)
            {
                ///Get the Lead-Dispatcher
                ILeadDispatcher leadDispatcher = leadDistributionFactory.GetDispatcher(DispatcherType.TerritoryDispatcher);
                ///Initialize the Agent-Scheduler algorithm
                leadDispatcher.InitializeAgentScheduler(leadDistributionFactory.GetAgentScheduler(AgentSchedulerType.LIFO));
                ///Dispatch the lead for scheduling
                assignedAgent = leadDispatcher.Dispatch(leadDetails);
            }
            OperationResult<IAgentDTO> result = CreateOperationResult(validateLead, assignedAgent);
            return result;
        }

        /// <summary>
        /// Adds the agent for territory.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        public void AddAgent(IAgentDTO agentDetails)
        {
            IAgentDataManager agentDataManager = new LeadDistributionDataFactory().GetAgentDataManager(DataComponentType.InMemoryData);
            agentDataManager.AddAgent(agentDetails);
        }

        /// <summary>
        /// Adds the territory data.
        /// </summary>
        /// <param name="territoryData">The territory data.</param>
        public void AddTerritoryData(ITerritoryDTO territoryData)
        {
            ITerritoryDataManager territoryDataManager = new LeadDistributionDataFactory().GetTerritoryDataManager(DataComponentType.InMemoryData);
            territoryDataManager.AddTerritoryData(territoryData);
        }

        /// <summary>
        /// Removes the agent.
        /// </summary>
        /// <param name="agentDetails">The agent details.</param>
        /// <returns></returns>
        public bool RemoveAgent(IAgentDTO agentDetails)
        {
            IAgentDataManager agentDataManager = new LeadDistributionDataFactory().GetAgentDataManager(DataComponentType.InMemoryData);
            return agentDataManager.RemoveAgent(agentDetails);
        }

        /// <summary>
        /// Cleans the data store.
        /// </summary>
        public void CleanDataStore()
        {
            ITerritoryDataManager territoryDataManager = new LeadDistributionDataFactory().GetTerritoryDataManager(DataComponentType.InMemoryData);
            territoryDataManager.CleanDataStore();
        }
        #endregion

        #region Private Methods

        /// <summary>
        /// Creates the operation result.
        /// </summary>
        /// <param name="validateLead">The validate lead.</param>
        /// <param name="assignedAgent">The assigned agent.</param>
        /// <returns></returns>
        private OperationResult<IAgentDTO> CreateOperationResult(IValidateLead validateLead, IAgentDTO assignedAgent)
        {
            OperationResult<IAgentDTO> result = new OperationResult<IAgentDTO>();
            if (validateLead.IsValid)
            {
                if (assignedAgent != null)///Create operation result with agent details
                {
                    result.Result = OperationResultType.Success;
                    result.Data = assignedAgent;
                    result.Message = AgentAssigned;
                }
                else///Create operation result for: No Agent available
                {
                    result.Result = OperationResultType.Failure;
                    result.Message = AgentNotAssigned;
                }
            }
            else///Create operation result for invalid data
            {
                result.Result = OperationResultType.Failure;
                result.Message = validateLead.Message;
            }
            return result;
        }

        #endregion
    }
}
