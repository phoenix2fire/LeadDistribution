using System.Collections.Generic;
using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;

namespace TTX.LeadDistribution.Data
{
    /// <summary>
    /// Territory data store
    /// </summary>
    public static class ApplicationDataStore
    {
        /// <summary>
        /// The territory-agent dictionary
        /// </summary>
        public static Dictionary<string, INodeContainerIterator<IAgentDTO>> TerritoryAgentDictionary = new Dictionary<string, INodeContainerIterator<IAgentDTO>>();

        /// <summary>
        /// The territory collection
        /// </summary>
        public static List<ITerritoryDTO> TerritoryCollection = new List<ITerritoryDTO>();

        /// <summary>
        /// The lead-agent dictionary
        /// </summary>
        public static Dictionary<int, IAgentDTO> LeadAgentDictionary = new Dictionary<int, IAgentDTO>();
    }
}
