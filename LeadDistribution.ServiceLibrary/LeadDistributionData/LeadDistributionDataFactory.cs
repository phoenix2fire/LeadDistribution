using TTX.LeadDistribution.Data;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public class LeadDistributionDataFactory
    {
        /// <summary>
        /// Gets the territory data manager.
        /// </summary>
        /// <param name="dataComponentType">Type of the data component.</param>
        /// <returns></returns>
        public ITerritoryDataManager GetTerritoryDataManager(DataComponentType dataComponentType)
        {
            ITerritoryDataManager territoryDataManager;
            switch (dataComponentType)
            {
                case DataComponentType.InMemoryData:
                    territoryDataManager = new TerritoryDataManager();
                    break;
                default:
                    territoryDataManager = new TerritoryDataManager();
                    break;
            }
            return territoryDataManager;
        }

        /// <summary>
        /// Gets the agent data manager.
        /// </summary>
        /// <param name="dataComponentType">Type of the data component.</param>
        /// <returns></returns>
        public IAgentDataManager GetAgentDataManager(DataComponentType dataComponentType)
        {
            IAgentDataManager agentDataManager;
            switch (dataComponentType)
            {
                case DataComponentType.InMemoryData:
                    agentDataManager = new AgentDataManager();
                    break;
                default:
                    agentDataManager = new AgentDataManager();
                    break;
            }
            return agentDataManager;
        }
    }
}
