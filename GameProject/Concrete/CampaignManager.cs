using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class CampaignManager : IOrderService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been successfully added! Campaign price is : " + campaign.CampaignPrice);
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been successfully removed!");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " has been successfully updated! New campaign price is : " + campaign.CampaignPrice);
        }
    }
}
