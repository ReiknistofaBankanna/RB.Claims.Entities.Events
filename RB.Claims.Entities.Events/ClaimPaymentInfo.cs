using System;

namespace RB.Claims.Entities.Events
{
    /// <summary>
    /// Upplýsingar um greiðslu. 
    /// Skilað fyrir atburða tegundir Payment.
    /// </summary>
    public class ClaimPaymentInfo
    {
        /// <summary>
        /// Auðkenni greiðslu.
        /// </summary>
        public string OperationReference { get; set; }
        /// <summary>
        /// Dagsetning þegar færsla er bókuð hjá RB.
        /// </summary>
        public DateTime BookingDate { get; set; }
        /// <summary>
        /// Vaxtadagsetning. Gildistökudagur eða vaxtadagsetning sem greiðsla miðast við.
        /// </summary>
        public DateTime? ValueDate { get; set; }
        /// <summary>
        /// Heildarupphæð greiðslu með áföllnum vöxtum og gjöldum.
        /// </summary>
        public decimal TotalPaid { get; set; }
        /// <summary>
        /// Fjármagnstekjuskattur.
        /// </summary>
        public decimal CapitalGainTax { get; set; }
        /// <summary>
        /// Segir til um það hvort búið sé að draga fjármagnstekjuskatt af greiðslu til kröfuhafa.
        /// </summary>
        public bool IsCapitalGainTaxWithdrawn { get; set; }
        /// <summary>
        /// Greitt tilkynningargjald.
        /// </summary>
        public decimal NoticeAndPaymentFee { get; set; }
        /// <summary>
        /// Greitt vanskilagjald.
        /// </summary>
        public decimal DefaultCharge { get; set; }
        /// <summary>
        /// Greiddur annar kostnaður.
        /// </summary>
        public decimal OtherCost { get; set; }
        /// <summary>
        /// Greiddur annar vanskilakostnaður.
        /// </summary>
        public decimal OtherDefaultCost { get; set; }
        /// <summary>
        /// Greiddir dráttarvextir.
        /// </summary>
        public decimal DefaultInterest { get; set; }
        /// <summary>
        /// Veittur afsláttur.
        /// </summary>
        public decimal DiscountGiven { get; set; }
        /// <summary>
        /// Mynt kröfunnar.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Upplýsingar um sölugengi gjaldmiðils kröfu.
        /// </summary>
        public decimal SellingRate { get; set; }
        /// <summary>
        /// Greidd upphæð inn á höfuðstól.
        /// </summary>
        public decimal PrincipalPaid { get; set; }
        /// <summary>
        /// Upplýsingar fyrir skatt skil.
        /// </summary>
        /// <value></value>
        public TaxExemptionInfo TaxExemptionInfo { get; set; }
        /// <summary>
        /// Heildar ráðstöfun til kröfuhafa.
        /// </summary>
        public decimal ClaimantDeposit { get; set; }
        /// <summary>
        /// Ráðstöfun vanskilagjalds til kröfuhafa eftir skatt.
        /// </summary>
        public decimal DefaultChargeDeposit { get; set; }
        /// <summary>
        ///Ráðstöfun dráttarvaxta til kröfuhafa eftir skatt.
        /// </summary>
        public decimal DefaultInterestDeposit { get; set; }
        /// <summary>
        /// Segir til um hvort greiðsla sé innborgun.
        /// </summary>
        public bool IsPartialPayment { get; set; }
        /// <summary>
        /// Segir til um hvort greiðsla sé endurgreiðsla.
        /// </summary>
        public bool IsRefundPayment { get; set; }
    }
}
