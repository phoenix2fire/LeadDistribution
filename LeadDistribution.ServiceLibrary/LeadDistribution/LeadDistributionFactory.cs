
namespace TTX.LeadDistribution.ServiceLibrary
{
    public class LeadDistributionFactory
    {
        #region Public Methods
        /// <summary>
        /// Gets the lead dispatcher.
        /// </summary>
        /// <param name="dispatcherType">Type of the dispatcher.</param>
        /// <returns></returns>
        public ILeadDispatcher GetDispatcher(DispatcherType dispatcherType)
        {
            ILeadDispatcher leadDispatcher;
            switch (dispatcherType)
            {
                case DispatcherType.TerritoryDispatcher:
                    leadDispatcher = new TerritoryDispatcher();
                    break;
                default:
                    leadDispatcher = new TerritoryDispatcher();
                    break;
            }
            return leadDispatcher;
        }

        /// <summary>
        /// Gets the agent scheduler.
        /// </summary>
        /// <param name="agentSchedulerType">Type of the agent scheduler.</param>
        /// <returns></returns>
        public IAgentScheduler GetAgentScheduler(AgentSchedulerType agentSchedulerType)
        {
            IAgentScheduler agentScheduler;
            switch (agentSchedulerType)
            {
                case AgentSchedulerType.LIFO:
                    agentScheduler = new LIFOAgentScheduler();
                    break;
                default:
                    agentScheduler = new LIFOAgentScheduler();
                    break;
            }
            return agentScheduler;
        }

        /// <summary>
        /// Gets the lead validator.
        /// </summary>
        /// <param name="validatorType">Type of the validator.</param>
        /// <returns></returns>
        public IValidateLead GetLeadValidator(LeadValidatorType validatorType)
        {
            IValidateLead validateLead;
            switch (validatorType)
            {
                case LeadValidatorType.ValidateTerritory:
                    validateLead = new ValidateLead();
                    break;
                default:
                    validateLead = new ValidateLead();
                    break;
            }
            return validateLead;
        }
        #endregion
    }
}
