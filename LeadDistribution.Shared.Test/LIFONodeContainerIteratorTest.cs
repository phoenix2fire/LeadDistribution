using TTX.LeadDistribution.DTO;
using TTX.LeadDistribution.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTX.LeadDistribution.Shared.Test
{
    [TestClass]
    public class LIFONodeContainerIteratorTest
    {
        private INodeContainerIterator<AgentDTO> agentContainerIterator;

        /// <summary>
        /// Initializes the data structure
        /// </summary>
        [TestInitialize]
        public void Initialize()
        {
            agentContainerIterator = new LIFONodeContainerIterator<AgentDTO>();
            AgentDTO newAgent = new AgentDTO() { ID = 1, Name = "NAgent1", Territory = "North" };
            agentContainerIterator.AddNode(newAgent);
        }

        /// <summary>
        /// Tests Addding of a node.
        /// </summary>
        [TestMethod]
        public void TestNodeContainerIterator_AddNode()
        {
            AgentDTO newAgent = new AgentDTO() { ID = 2, Name = "NAgent2", Territory = "North" };
            agentContainerIterator.AddNode(newAgent);
            Assert.AreEqual(newAgent, agentContainerIterator.PeekCurrent());
        }

        /// <summary>
        /// Tests Scheduling of a node.
        /// </summary>
        [TestMethod]
        public void TestNodeContainerIterator_ScheduleNode()
        {
            if (agentContainerIterator.HasNodes())
            {
                var node = agentContainerIterator.PeekCurrent();
                agentContainerIterator.MoveNext();
                Assert.AreEqual(node, agentContainerIterator.PreviousNode());
            }
        }

        /// <summary>
        /// Tests Removing of the node.
        /// </summary>
        [TestMethod]
        public void TestNodeContainerIterator_RemoveNode()
        {
            AgentDTO agentToRemove = new AgentDTO() { ID = 1, Name = "NAgent1", Territory = "North" };
            Assert.AreEqual(true, agentContainerIterator.RemoveNode(agentToRemove));
        }

        [TestMethod]
        public void TestNodeContainerIterator_RemoveAlreadyRemovedNode()
        {
            AgentDTO agent = new AgentDTO() { ID = 1, Name = "NAgent1", Territory = "North" };
            ///Remove a node
            agentContainerIterator.RemoveNode(agent);
            ///Try removing again
            Assert.AreEqual(false, agentContainerIterator.RemoveNode(agent));
        }

        /// <summary>
        /// Tests the node container iterator for adding and scheduling a node.
        /// </summary>
        [TestMethod]
        public void TestNodeContainerIterator_AddAndScheduleNode()
        {
            AgentDTO newAgent = new AgentDTO() { ID = 2, Name = "NAgent2", Territory = "North" };
            agentContainerIterator.AddNode(newAgent);
            ///Schedule the node
            agentContainerIterator.MoveNext();
            Assert.AreEqual(newAgent, agentContainerIterator.PreviousNode());
        }

        /// <summary>
        /// Cleans up the agent iterator.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            agentContainerIterator = null;
        }
    }
}
