namespace AlohaOrderOnLine.Model
{
    public class ComboItemModel
    {
        public int PromoId { get; set; }
        public int PromoType { get; set; }
        public float Price { get; set; }
        public OrderWebSalesGroupModel OrderWebSalesGroup { get; set; }

    }
}
