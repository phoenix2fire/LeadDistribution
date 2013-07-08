using System.Collections.ObjectModel;

namespace TTX.LeadDistribution.Shared
{
    /// <summary>
    /// Contract for Node container iteration
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface INodeContainerIterator<T>
    {
        /// Moves to the next node.
        /// </summary>
        void MoveNext();

        /// <summary>
        /// Adds the node.
        /// </summary>
        /// <param name="nodeDetails">The node details.</param>
        void AddNode(T nodeDetails);

        /// <summary>
        /// Removes the node.
        /// </summary>
        /// <param name="nodeDetails">The node details.</param>
        /// <returns></returns>
        bool RemoveNode(T nodeDetails);

        /// <summary>
        /// Determines whether [has availabe nodes].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has availabe nodes]; otherwise, <c>false</c>.
        /// </returns>
        bool HasNodes();

        /// <summary>
        /// Gets the current node.
        /// </summary>
        /// <returns></returns>
        T PeekCurrent();

        /// <summary>
        /// Gets the previous node.
        /// </summary>
        /// <returns></returns>
        T PreviousNode();

        /// <summary>
        /// Gets the list of nodes.
        /// </summary>
        /// <returns></returns>
        ReadOnlyCollection<T> GetNodeContainer();
    }
}
