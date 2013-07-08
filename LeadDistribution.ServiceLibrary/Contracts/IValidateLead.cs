using TTX.LeadDistribution.DTO;

namespace TTX.LeadDistribution.ServiceLibrary
{
    public interface IValidateLead
    {
        /// <summary>
        /// Gets a value indicating whether the lead instance is valid.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the lead instance is valid; otherwise, <c>false</c>.
        /// </value>
        bool IsValid { get; }

        /// <summary>
        /// Gets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        string Message { get; }

         /// <summary>
         /// Validates the specified lead details.
         /// </summary>
         /// <param name="leadDetails">The lead details.</param>
         void Validate(ILeadDTO leadDetails);
    }
}
