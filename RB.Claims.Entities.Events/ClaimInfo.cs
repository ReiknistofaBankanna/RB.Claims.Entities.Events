using System;

namespace RB.Claims.Entities.Events
{
    /// <summary>
    /// Upplýsingar um kröfu.
    /// Skilað fyrir atburða tegundir ClaimCreation, ClaimUpdate, ClaimCancellation, FinalDueDate, Payment.    
    /// </summary>
    public class ClaimInfo
    {
        /// <summary>
        /// Kröfunúmer (BANK+HBOK+NUMER).
        /// </summary>
        public string ClaimId { get; set; }
        /// <summary>
        /// Kennitala kröfuhafa.
        /// </summary>
        public string ClaimantId { get; set; }
        /// <summary>
        /// Gjalddagi.
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// Kennitala greiðanda.
        /// </summary>
        public string PayorId { get; set; }
        /// <summary>
        /// Höfuðstóll kröfu.
        /// </summary>
        public decimal Principal { get; set; }
        /// <summary>
        /// Eindagi.
        /// </summary>  
        public DateTime FinalDueDate { get; set; }
        /// <summary>
        /// Segir til um hvort greiða megi inn á kröfu.
        /// </summary>
        public bool IsPartialPaymentAllowed { get; set; }
        /// <summary>
        /// Segir til um hvort krafa sé skráð í beingreiðslu.
        /// </summary>
        public bool IsDirectDebit { get; set; }
        /// <summary>
        /// Er greiðsla valkvæð fyrir greiðanda.
        /// </summary>
        public bool IsPaymentOptional { get; set; }

        /// <summary>
        /// Kröfutegund.
        /// </summary>
        public ClaimType ClaimType { get; set; }
    }
}
