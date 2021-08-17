using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Entities
{
    class Game : IEntity
    {
        public Game(int id, int categoryId, string gameName, string campaignName, double gamePrice)
        {
            Id = id;
            CategoryId = categoryId;
            GameName = gameName;
            CampaignName = campaignName;
            GamePrice = gamePrice;
        }
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string GameName { get; set; }
        public string CampaignName { get; set; }
        public double GamePrice { get; set; }

    }
}
