using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.Data
{
    public class TerritoryDataManager: ITerritoryDataManager
    {
        /// <summary>
        /// Gets the territory by name.
        /// </summary>
        /// <param name="territoryName">Name of the territory.</param>
        /// <returns></returns>
        public ITerritoryDTO GetTerritoryByName(string territoryName)
        {
            ITerritoryDTO territoryData = ApplicationDataStore.TerritoryCollection.Find(territory => territory.Name.Equals(territoryName));
            return territoryData;
        }

        /// <summary>
        /// Adds the territory data.
        /// </summary>
        /// <param name="territoryData">The territory data.</param>
        public void AddTerritoryData(ITerritoryDTO territoryData)
        {
            ApplicationDataStore.TerritoryCollection.Add(territoryData);
            ApplicationDataStore.TerritoryAgentDictionary.Add(territoryData.Name, new LIFONodeContainerIterator<IAgentDTO>());
        }

        /// <summary>
        /// Cleans the data store.
        /// </summary>
        public void CleanDataStore()
        {
            ApplicationDataStore.LeadAgentDictionary.Clear();
            ApplicationDataStore.TerritoryAgentDictionary.Clear();
            ApplicationDataStore.TerritoryCollection.Clear();
        }
    }
}
