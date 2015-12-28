namespace AlohaOrderOnLine.Model
{
    public class InOrderModel
    {
        public int SiteId { get; set; } // required
        public int  OrderId { get; set; } 
        public int  DesignId { get; set; }
        public int MenuId { get; set; }
        public string PromiseDateTime { get; set; } // required
        public InOrderLineItemModel LineItem { get; set; }
        public ComboItemModel ComboItem { get; set; }
        public int OrderMode { get; set; } // required
        public bool UpdateTimeDisabled { get; set; }
        public int PaymentMode { get; set; } // required
        public int OrderSource { get; set; }
        public int  Destination { get; set; }
        public bool ShouldManualRelease { get; set; }
        public int TaxJurisdictionId { get; set; }
        public CustomerModel Customer { get; set; } //required
        public AddressesModel CustomerAddress { get; set; }
        public string SpecialInstructions { get; set; }
        public string LoyaltyNumber { get; set; }
        public int CompId { get; set; }
        public int ReferenceNumber { get; set; }
        
    }
}
