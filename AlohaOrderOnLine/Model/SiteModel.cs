namespace AlohaOrderOnLine.Model
{
    public class SiteModel
    {
        public int  SiteId { get; set; }
        public string ExternalId { get; set; }
        public string SiteName { get; set; }
        public string Description { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string VoicePhone { get; set; }
        public string FaxPhone { get; set; }
        public string WebDesignId { get; set; }
        public bool IsEnabled { get; set; }
        public int TimeOffsetHours { get; set; }
        public int  TimeOffsetMinutes { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public string LastModifiedTimestamp { get; set; }
        public bool IsMobileEnabled { get; set; }
        public string CreditProcessingMode { get; set; }
        public string SiteStatus { get; set; }
        public string SupportedOrderModes { get; set; }
        public HoursModel Hours { get; set; }
        public SpecialEventsModel SpecialEventsModel { get; set; }
        public int StoreId { get; set; }
        public string[] AvailableProducts { get; set; }
    }
}
