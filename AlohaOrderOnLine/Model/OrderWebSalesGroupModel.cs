namespace AlohaOrderOnLine.Model
{
    public class OrderWebSalesGroupModel
    {
        public int WebSalesGroupId { get; set; }
        public int LineItemNumber { get; set; }
        public int GroupLineId { get; set; }
        public string MenuItemName { get; set; }
        public int SalesItemId { get; set; }
    }
}
