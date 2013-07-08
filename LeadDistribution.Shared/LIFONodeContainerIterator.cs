using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TTX.LeadDistribution.Shared
{
    /// <summary>
    /// Iterator class for all agents
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class LIFONodeContainerIterator<T>: INodeContainerIterator<T>
    {
        #region Private Members

        private LinkedList<T> nodeList = new LinkedList<T>();

        /// <summary>
        /// Gets or sets the nodes.
        /// </summary>
        /// <value>
        /// The lits of items.
        /// </value>
        private LinkedList<T> NodeList
        {
            get
            {
                return nodeList;
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Moves to the next node.
        /// </summary>
        public void MoveNext()
        {
            LinkedListNode<T> firstNode = NodeList.First;
            NodeList.RemoveFirst();
            NodeList.AddLast(firstNode.Value);
        }

        /// <summary>
        /// Adds a new node.
        /// </summary>
        /// <param name="nodeDetails">The node details.</param>
        public void AddNode(T nodeDetails)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(nodeDetails);
            NodeList.AddFirst(node);
        }

        /// <summary>
        /// Removes the given node.
        /// </summary>
        /// <param name="nodeDetails">The node details.</param>
        /// <returns></returns>
        public bool RemoveNode(T nodeDetails)
        {
            bool isRemoved = false;
            LinkedListNode<T> linkedListNode = NodeList.Find(nodeDetails);
            if (linkedListNode != null)
            {
                NodeList.Remove(linkedListNode);
                isRemoved = true;
            }
            return isRemoved;
        }

        /// <summary>
        /// Determines whether [has availabe nodes].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has availabe nodes]; otherwise, <c>false</c>.
        /// </returns>
        public bool HasNodes()
        {
            return this.NodeList.Count > 0;
        }

        /// <summary>
        /// Gets the current node.
        /// </summary>
        /// <returns></returns>
        public T PeekCurrent()
        {
            return this.NodeList.First.Value;
        }

        /// <summary>
        /// Gets the previous node.
        /// </summary>
        /// <returns></returns>
        public T PreviousNode()
        {
            return this.nodeList.Last.Value;
        }

        /// <summary>
        /// Gets the list of nodes.
        /// </summary>
        /// <returns></returns>
        public ReadOnlyCollection<T> GetNodeContainer()
        {
            return new ReadOnlyCollection<T>(this.nodeList.ToList());
        }
        #endregion
    }
}
