using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " has been successfully added! Price is : " + game.GamePrice);
        }

        public void Remove(Game game)
        {
            Console.WriteLine(game.GameName + " has been successfully removed!");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " has been successfully updated! New price is : " + game.GamePrice);
        }
    }
}
