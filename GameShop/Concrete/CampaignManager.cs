using GameShop.Abstract;
using GameShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameShop.Concrete
{
    public class CampaignManager : ICampaignService
    {
        public void FinishCampaign(Campaign campaign)
        {
            Console.WriteLine("{0}-{1} Kampanya Sona Erdi");
        }

        public void StartCampaign(Campaign campaign)
        {
            Product product = new Product();
            product.Price = (product.Price) - ((product.Price) * (campaign.Rate / 100));
            Console.WriteLine("Kampanya Başladı!");
        }

        public void UpdateCampaign(Campaign campaign,Campaign campaign1)
        {
          campaign.CampaignName = campaign1.CampaignName;
          campaign.Rate = campaign1.Rate;
          Console.WriteLine("Seri No:{0}  Kampanya Seri No:{1} kampanyasıyla güncellendi",campaign.CampaignNo,campaign1.CampaignNo); 
        }
    }
}
