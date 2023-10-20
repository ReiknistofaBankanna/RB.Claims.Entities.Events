namespace RB.Claims.Entities.Events
{
    /// <summary>
    /// Skatt upplýsingar tengdar greiðslunni 
    /// </summary>
    public class TaxExemptionInfo
    {
        /// <summary>
        /// Er skárður á undanþáguskrá
        /// </summary>
        public bool HasTaxExemption { get; set; }

        /// <summary>
        /// Engin skattur greiddur
        /// </summary>
        public bool ZeroTax { get; set; }

        /// <summary>
        /// Landakóði.
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Heimilisfang.
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Póstnúmer og bær
        /// </summary>
        public string PostalCodeAndCity { get; set; }

        /// <summary>
        /// Sýsla.
        /// </summary>
        public string Municipality { get; set; }

        /// <summary>        
        /// Tax Identification Number.  (Valid if payer pays taxes in foreign countries).
        /// </summary>
        public string TIN { get; set; }

        /// <summary>
        /// OECD kóði.
        /// </summary>
        public string TaxPayerTypeCode { get; set; }

        /// <summary>
        /// Tegundgreiðslu.
        /// </summary>      
        public string PaymentType { get; set; }
    }
}
