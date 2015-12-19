﻿namespace AlohaOrderOnLine.Model
{
    public class SiteAttributesModel
    {
        public string AttributeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsVisibleOnSiteLocator { get; set; }
        public int Ranking { get; set; }
        public int ImageId { get; set; }
    }
}
