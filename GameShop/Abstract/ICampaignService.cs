using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Abstract
{
    public interface ICampaignService
    {
        void StartCampaign(Campaign campaign);
        void FinishCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign,Campaign campaign1);
    }
}
