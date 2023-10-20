using System;

namespace RB.Claims.Entities.Events
{
    /// <summary>
    /// Upplýsingar um bunka. Skilað fyrir atburða tegundir BatchCompleted
    /// </summary>
    public class BatchInfo
    {
        /// <summary>
        /// Tegund bunka.
        /// </summary>
        public BatchType Type { get; set; }
        /// <summary>
        /// Auðkenni bunka.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Valkvætt auðkenni sem sendandi getur sett á bunkann.
        /// </summary>
        public string ExternalId { get; set; }
        /// <summary>
        /// Kennitala kröfuhafa.
        /// </summary>
        public string ClaimantId { get; set; }
        /// <summary>
        /// Stofndagsetning bunka hjá RB.
        /// </summary>
        public DateTime CommencementDate { get; set; }
        /// <summary>
        /// Heildar upphæð í bunka.
        /// </summary>
        public decimal TotalAmount { get; set; }
        /// <summary>
        /// Færslufjöldi í bunka.
        /// </summary>
        public int ItemCount { get; set; }
        /// <summary>
        /// Færslufjöldi í bunka sem tókst að ljúka án villu.
        /// </summary>
        public int ItemSuccessCount { get; set; }
        /// <summary>
        /// Færslufjöldi í bunka sem lauk með villu.
        /// </summary>
        public int ItemErrorCount { get; set; }
    }
}
