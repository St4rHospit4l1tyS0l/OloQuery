namespace AlohaOrderOnLine.Model
{
    public class HoursModel
    {
        public string DayOfWeek { get; set; }
        public TimeSpanModel OpeningTimeModel { get; set; }
        public TimeSpanModel ClosingTime { get; set; }
        public bool IsClosed { get; set; }
        public bool IsClosedForDelivery { get; set; }
        public string Delivery1Start { get; set; }
        public string Delivery1End { get; set; }
        public string Delivery2Start { get; set; }
        public string Delivery2End { get; set; }
    }
}
