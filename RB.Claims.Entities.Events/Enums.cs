namespace RB.Claims.Entities.Events
{

    /// <summary>
    /// Tegund atburðar.
    /// </summary>
    public enum EventType
    {
        /// <summary>Stofnun kröfu.</summary>
        ClaimCreation,
        /// <summary>Uppfærsla á kröfu.</summary>
        ClaimUpdate,
        /// <summary>Niðurfelling kröfu.</summary>
        ClaimCancellation,
        /// <summary>Greiðsla kröfu.</summary>
        Payment,
        /// <summary>Krafa komin á eindaga.</summary>
        FinalDueDate,
        /// <summary>IK bunki hefur lokið vinnslu.</summary>
        BatchCompleted,
    }

    /// <summary>
    /// Tegund áskriftar.
    /// </summary>
    public enum SubscriptionType
    {
        /// <summary>Greiðanda áskrift.Greiðandi hefur gefið leyfi á að fá eventa um IK þvert á banka.</summary>
        PayorSubscription,
        /// <summary>Banka áskrift. Atburðir sem banki hefur beðið um að fá um sín gögn í IK </summary>
        BankSubscription
    }

    /// <summary>
    /// Tegund aðgerðar sem var framkvæmd á færslurnar í bunkanum.
    /// </summary>
    public enum BatchType
    {
        /// <remarks/>
        CreateClaims,
        /// <remarks/>
        AlterClaims,
        /// <remarks/>
        DeleteClaims,
        /// <remarks/>
        AlterClaimsSecondaryCollection,
        /// <remarks/>
        CreateCollectionLetters,
    }

    /// <summary>
    /// Tegund kröfu
    /// </summary>
    public enum ClaimType
    {
        /// <summary>
        /// Almenn krafa.
        /// </summary>
        NormalClaim = 0,
        /// <summary>
        /// Valgreiðslukrafa.
        /// </summary>
        OptionalPaymentClaim = 1,
        /// <summary>
        /// Endurgreiðslukrafa.
        /// </summary>        
        RefundClaim = 2,
        /// <summary>
        /// Eftirstöðvakrafa ríkisins.
        /// </summary>
        BalanceClaim = 3
    }
}
