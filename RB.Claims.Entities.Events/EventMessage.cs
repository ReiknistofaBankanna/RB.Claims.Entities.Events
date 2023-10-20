using System;

namespace RB.Claims.Entities.Events
{
    /// <summary>
    /// Atburða skilaboð fyrir viðskiptavini RB.
    /// </summary>
    public class EventMessage
    {
        /// <summary>
        /// Tegund atburðar.
        /// </summary>
        public EventType Type { get; set; }

        /// <summary>
        /// Tegund áskriftar.
        /// </summary>
        public SubscriptionType SubscriptionType { get; set; }

        /// <summary>
        /// Eigandi gagna.
        /// </summary>
        public string DataOwner { get; set; }

        /// <summary>
        /// Framkvæmdaraðili atburðar.
        /// Getur verið null ef banki hefur ekki rétt á að sjá notanda.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// Tími atburðar.
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Sendingar banki.
        /// </summary>
        public string TransactionBank { get; set; }

        /// <summary>
        /// Upplýsingar um kröfu.
        /// Skilað fyrir atburða tegundir ClaimCreation, ClaimUpdate, ClaimCancellation, FinalDueDate, Payment.    
        /// </summary>
        public ClaimInfo ClaimInfo { get; set; }

        /// <summary>
        /// Upplýsingar um greiðslu. 
        /// Skilað fyrir atburða tegundir Payment.
        /// </summary>
        public ClaimPaymentInfo PaymentInfo { get; set; }

        /// <summary>
        /// Upplýsingar um bunka. 
        /// Skilað fyrir atburða tegundir BatchCompleted
        /// </summary>
        public BatchInfo BatchInfo { get; set; }
    }
}