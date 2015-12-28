namespace AlohaOrderOnLine.Model
{
    public class InOrderLineItemModel
    {
        public int SequenceNumber { get; set; }
        public int ItemOptionGroupId { get; set; }
        public int SalesItemOptionId { get; set; }
        public int Action { get; set; }
        public int DefaultAction { get; set; }
        public int ItemLineNumber { get; set; }

    }
}
