using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new NewEStateUserValidationManager());
            customerManager.Add(new Customer(1, "3", "Yunus Emre", "Kayaoğlu", 2002));

            GameManager gameManager = new GameManager();

            gameManager.Add(new Game(1, 1, "Valorant", "RiotGames", 0));

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign(1, "Yaz indirimi", 30));
        }
    }
}
