namespace AlohaOrderOnLine.Model
{
    public class SiteMenusModel
    {
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string MenuType { get; set; }
        public string ExternalId { get; set; }
        public string SupportedOrderModes { get; set; }
        public bool IsVisible { get; set; }
        public string MenuAttribute { get; set; }
        public string DisplayName { get; set; }
        public int SubMenus { get; set; }
    }
}
