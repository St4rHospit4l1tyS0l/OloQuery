namespace AlohaOrderOnLine.Model
{
    public class AddressesModel
    {
        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public bool IsDefault { get; set; }
        public string Description { get; set; }
        public string DepartmentName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public ExtraDataModel ExtraData { get; set; }

    }
}
