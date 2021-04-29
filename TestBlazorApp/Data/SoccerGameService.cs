using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Data
{
    public class SoccerGameService
    {
        public Task<List<SoccerGame>> GetSoccerGamesAsync(DateTime startDate)
        {
            SoccerGame newGame = new SoccerGame()
            {
                GameId = 1,
                Project = "Spring2021",
                Region = "R0894",
                GameTime = DateTime.Now,
                Status = "Open",
                GameVenue = new Venue()
                {
                    id = new Guid(),
                    RegionCode = "R0894",
                    Location = "MMS",
                    FieldId = "01",
                    SubField = ""
                },
                GameLength = 90,
                SlotLenth = 120,
                HomeTeam = "R0894-19UB-01",
                AwayTeam = "R0498-19UB-02",
                Official = "Center Referee"
            };

            List<SoccerGame> Games = new List<SoccerGame>();
            Games.Add(newGame);
            return Task.FromResult(Games);
        }

        public Task<List<SoccerGame>> GetSubscribedGamesAsync()
        {
            DataGenerator dg = new DataGenerator();

            List<SoccerGame> games = new List<SoccerGame>();
            for (int i = 0; i < 3; i++)
            {
                games.Add(dg.createSoccerGame());
            }

            return Task.FromResult(games);
        }
    }
}
