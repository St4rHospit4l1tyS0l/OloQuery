namespace AlohaOrderOnLine.Model
{
    public class SpecialEventsModel
    {
        public int  SpecialEventId { get; set; }
        public string SpecialEventStartDate { get; set; }
        public string Name { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
        public bool IsClosed { get; set; }
        public bool IsClosedDelivery { get; set; }
        public string SpecialEventEndDate { get; set; }
        public bool IsCompanyWide { get; set; }
        public string Delivery1Start { get; set; }
        public string Delivery1End { get; set; }
        public string Delivery2Start { get; set; }
        public string Delivery2End { get; set; }
        public string SpecialEventPurpose { get; set; }
    }
}
