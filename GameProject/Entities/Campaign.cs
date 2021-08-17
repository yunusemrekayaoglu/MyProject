using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    class Campaign : IEntity
    {
        public Campaign(int id, string campaignName, double campaignPrice)
        {
            Id = id;
            CampaignName = campaignName;
            CampaignPrice = campaignPrice;
        }
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignPrice { get; set; }
    }
}
