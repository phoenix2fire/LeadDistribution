using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.ServiceLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTX.LeadDistribution.ServiceLibrary.Test
{
    [TestClass]
    public class LeadDistributionServiceTest
    {
        private ILeadDistributionService service;

        /// <summary>
        /// Creates the data store.
        /// </summary>
        [TestInitialize]
        public void CreateDataStore()
        {
            service = new LeadDistributionService();
            ///Add territories: North, South, East and West
            service.AddTerritoryData(new TerritoryDTO() { ID = 1, Name = "North" });
            service.AddTerritoryData(new TerritoryDTO() { ID = 2, Name = "South" });
            service.AddTerritoryData(new TerritoryDTO() { ID = 3, Name = "East" });
            service.AddTerritoryData(new TerritoryDTO() { ID = 4, Name = "West" });

            ///Add six agents in North
            service.AddAgent(new AgentDTO() { ID = 1, Name = "NAgent1", Territory = "North" });
            service.AddAgent(new AgentDTO() { ID = 2, Name = "NAgent2", Territory = "North" });
            service.AddAgent(new AgentDTO() { ID = 3, Name = "NAgent3", Territory = "North" });
            service.AddAgent(new AgentDTO() { ID = 4, Name = "NAgent4", Territory = "North" });
            service.AddAgent(new AgentDTO() { ID = 5, Name = "NAgent5", Territory = "North" });
            service.AddAgent(new AgentDTO() { ID = 6, Name = "NAgent6", Territory = "North" });

            ///Add four agents in South
            service.AddAgent(new AgentDTO() { ID = 1, Name = "SAgent1", Territory = "South" });
            service.AddAgent(new AgentDTO() { ID = 2, Name = "SAgent2", Territory = "South" });
            service.AddAgent(new AgentDTO() { ID = 3, Name = "SAgent3", Territory = "South" });
            service.AddAgent(new AgentDTO() { ID = 4, Name = "SAgent4", Territory = "South" });

            ///Add five agents in East
            service.AddAgent(new AgentDTO() { ID = 1, Name = "EAgent1", Territory = "East" });
            service.AddAgent(new AgentDTO() { ID = 2, Name = "EAgent2", Territory = "East" });
            service.AddAgent(new AgentDTO() { ID = 3, Name = "EAgent3", Territory = "East" });
            service.AddAgent(new AgentDTO() { ID = 4, Name = "EAgent4", Territory = "East" });
            service.AddAgent(new AgentDTO() { ID = 5, Name = "EAgent5", Territory = "East" });

            ///Add three agents in West
            service.AddAgent(new AgentDTO() { ID = 1, Name = "WAgent1", Territory = "West" });
            service.AddAgent(new AgentDTO() { ID = 2, Name = "WAgent2", Territory = "West" });
            service.AddAgent(new AgentDTO() { ID = 3, Name = "WAgent3", Territory = "West" });

        }

        /// <summary>
        /// Tests the process all north leads.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessAllNorthLeads()
        {
            LeadDTO newLead = new LeadDTO() { ID = 1, Interest = "Health Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent6", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 2, Interest = "Gold Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent5", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 3, Interest = "Wealth Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent4", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 4, Interest = "Car Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent3", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 5, Interest = "Mobile Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent2", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 6, Interest = "Health Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent1", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests the process all south leads.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessAllSouthLeads()
        {
            LeadDTO newLead = new LeadDTO() { ID = 1, Interest = "Life Insurance", Name = "John Doe", Territory = "South" };
            Assert.AreEqual("SAgent4", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 2, Interest = "Health Insurance", Name = "John Doe", Territory = "South" };
            Assert.AreEqual("SAgent3", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 3, Interest = "Car Insurance", Name = "John Doe", Territory = "South" };
            Assert.AreEqual("SAgent2", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 4, Interest = "Travel Insurance", Name = "John Doe", Territory = "South" };
            Assert.AreEqual("SAgent1", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests the process all west leads.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessAllWestLeads()
        {
            LeadDTO newLead = new LeadDTO() { ID = 1, Interest = "Car Insurance", Name = "John Doe", Territory = "West" };
            Assert.AreEqual("WAgent3", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 2, Interest = "House Insurance", Name = "John Doe", Territory = "West" };
            Assert.AreEqual("WAgent2", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 3, Interest = "Travel Insurance", Name = "John Doe", Territory = "West" };
            Assert.AreEqual("WAgent1", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests the process all east leads.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessAllEastLeads()
        {
            LeadDTO newLead = new LeadDTO() { ID = 1, Interest = "Life Insurance", Name = "John Doe", Territory = "East" };
            Assert.AreEqual("EAgent5", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 2, Interest = "Life Insurance", Name = "John Doe", Territory = "East" };
            Assert.AreEqual("EAgent4", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 3, Interest = "Car Insurance", Name = "John Doe", Territory = "East" };
            Assert.AreEqual("EAgent3", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 4, Interest = "House Insurance", Name = "John Doe", Territory = "East" };
            Assert.AreEqual("EAgent2", service.ProcessLead(newLead).Data.Name);

            newLead = new LeadDTO() { ID = 5, Interest = "Travel Insurance", Name = "John Doe", Territory = "East" };
            Assert.AreEqual("EAgent1", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests the add new agent logic.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_AddNewAgent()
        {
            LeadDTO newLead = new LeadDTO() { ID = 1, Interest = "Car Insurance", Name = "John Doe", Territory = "North" };
            ///Hire a new agent in North region
            service.AddAgent(new AgentDTO() { ID = 7, Name = "NAgent7", Territory = "North" });
            ///Send a lead in north region
            Assert.AreEqual("NAgent7", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests Removing of agent.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_RemoveAgent()
        {
            ///Try Removing an agent
            AgentDTO availableAgent = new AgentDTO() { ID = 1, Name = "NAgent1", Territory = "North" };
            Assert.AreEqual(true, service.RemoveAgent(availableAgent));
        }

        /// <summary>
        /// Tests the processing of lead when all agents have been scheduled at least once.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessLeadWhenAllAgentHaveBeenScheduledOnce()
        {
            ///Schedule all agents for north region
            TestLeadDistribution_ProcessAllNorthLeads();
            ///Send a lead to  north region
            LeadDTO newLead = new LeadDTO() { ID = 7, Interest = "Life Insurance", Name = "John Doe", Territory = "North" };
            Assert.AreEqual("NAgent6", service.ProcessLead(newLead).Data.Name);
        }

        /// <summary>
        /// Tests the processing of already associated lead.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessAlreadyAssociatedLead()
        {
            LeadDTO lead = new LeadDTO() { ID = 1, Interest = "Life Insurance", Name = "John Doe", Territory = "North" };
            service.ProcessLead(lead);
            Assert.AreEqual(OperationResultType.Failure, service.ProcessLead(lead).Result);
        }

        /// <summary>
        /// Tests the processing of lead with invaid region.
        /// </summary>
        [TestMethod]
        public void TestLeadDistribution_ProcessInvalidRegionLead()
        {
            LeadDTO lead = new LeadDTO() { ID = 1, Interest = "Life Insurance", Name = "John Doe", Territory = "NorthWest" };
            Assert.AreEqual(OperationResultType.Failure, service.ProcessLead(lead).Result);
        }

        /// <summary>
        /// Cleans the data store.
        /// </summary>
        [TestCleanup]
        public void CleanDataStore()
        {
            service.CleanDataStore();
        }
    }
}
