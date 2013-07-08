using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.Data
{
    public interface ITerritoryDataManager
    {
         /// <summary>
        /// Gets the territory by name.
        /// </summary>
        /// <param name="territoryName">Name of the territory.</param>
        /// <returns></returns>
        ITerritoryDTO GetTerritoryByName(string territoryName);

        /// <summary>
        /// Adds the territory data.
        /// </summary>
        /// <param name="territoryData">The territory data.</param>
        void AddTerritoryData(ITerritoryDTO territoryData);

        /// <summary>
        /// Cleans the data store.
        /// </summary>
        void CleanDataStore();
    }
}
