using TTX.LeadDistribution.Data;
using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public class ValidateLead: IValidateLead
    {
        #region Constants
        private const string ValidLeadMessage = "Valid lead provided.";
        private const string AlreadyAssociatedLeadMessage = "The lead is already associated to an agent.";
        private const string InValidTerritoryMessage = "The lead originates from an invalid territory.";
        #endregion

        #region Public Members

        /// <summary>
        /// Gets a value indicating whether the lead instance is valid.
        /// </summary>
        /// <value>
        /// <c>true</c> if the lead instance is valid; otherwise, <c>false</c>.
        /// </value>
        public bool IsValid { get; private set; }

        /// <summary>
        /// Gets the message containing information for validation.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; private set; }
        
        #endregion

        #region Public Methods
        /// <summary>
        /// Validates the specified lead details.
        /// </summary>
        /// <param name="leadDetails">The lead details.</param>
        public void Validate(ILeadDTO leadDetails)
        {
            if (!string.IsNullOrWhiteSpace(leadDetails.Territory))
            {
                LeadDistributionDataFactory leadDistributionDataFactory = new LeadDistributionDataFactory();
                ITerritoryDataManager territoryDataManager = leadDistributionDataFactory.GetTerritoryDataManager(DataComponentType.InMemoryData);
                ITerritoryDTO territory = territoryDataManager.GetTerritoryByName(leadDetails.Territory);
                IAgentDataManager agentDataManager = leadDistributionDataFactory.GetAgentDataManager(DataComponentType.InMemoryData);
                if (territory == null) ///Check for valid territory
                {
                    Message = InValidTerritoryMessage;
                }
                else if (agentDataManager.IsLeadAssociatedWithAgent(leadDetails.ID))///Check for already processed lead
                {
                    Message = AlreadyAssociatedLeadMessage;
                }
                else
                {
                    IsValid = true;
                    Message = ValidLeadMessage;
                }
            }
        }
        #endregion

    }
}
