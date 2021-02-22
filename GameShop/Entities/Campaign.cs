using GameShop.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.MernisServiceReference
{
    public class Campaign : IEntity
    {
        public int CampaignNo { get; set; }
        public string Category { get; set; }
        public string CampaignName { get; set; }
        public double Rate { get; set; }
    }
}
