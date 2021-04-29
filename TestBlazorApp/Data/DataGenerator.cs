using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Data
{
    public class DataGenerator
    {
        private List<string> _coaches;
        private List<string> _referees;
        private List<string> _areas;
        private List<string> _regions;
        private List<string> _divisions;
        private List<string> _biologicalGenders;
        private List<string> _teamIds;
        private List<Venue> _gameVenues;

        public List<string> Coaches
        {
            get { return _coaches; }
            set { _coaches = value; }
        }
        public List<string> Referees
        {
            get { return _referees; }
            set { _referees = value; }
        }
        public List<string> Areas
        {
            get { return _areas; }
            set { _areas = value; }
        }
        public List<string> Regions
        {
            get { return _regions; }
            set { _regions = value; }
        }
        public List<string> Divisions
        {
            get { return _divisions; }
            set { _divisions = value; }
        }
        public List<string> BiologicalGenders
        {
            get { return _biologicalGenders; }
            set { _biologicalGenders = value; }
        }
        public List<string> TeamIds
        {
            get { return _teamIds; }
            set { _teamIds = value; }
        }
        public List<Venue> GameVenues
        {
            get { return _gameVenues; }
            set { _gameVenues = value; }
        }

        public DataGenerator()
        {
            _coaches = new List<string>() { "McCoy", "Hatfield", "Jones", "Harness", "Hannah", "Freeman" };
            _referees = new List<string>() { "Price, John", "Vechinski, Douglas", "Duke, Greg", "Hutchinson, David", "Reynolds, Tracy", "Loyd, Josh" };
            _areas = new List<string>() { "05C" };
            _regions = new List<string>() { "0894", "0498", "0160", "0778", "1174", "0914" };
            _divisions = new List<string>() { "05U", "06U", "07U", "08U", "10U", "12U", "14U", "16U", "19U" };
            _biologicalGenders = new List<string>() { "B", "G", "C" };
            _teamIds = new List<string>() { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10" };
            _gameVenues = new List<Venue>()
            {
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Asbury", FieldId= "E"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Asbury", FieldId= "W"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Endeavor", FieldId= "NW"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Endeavor", FieldId= "NE"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Endeavor", FieldId= "SW"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Endeavor", FieldId= "SE"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "MMS"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Calvary Baptist"},
                new Venue(){id = new Guid(), RegionCode = "0894", Location = "Harvest Baptist"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "1"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "2"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "3"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "4"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "5"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "6"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "7"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "8"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Dublin", FieldId= "9"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Palmer", FieldId= "1"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Palmer", FieldId= "2"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Palmer", FieldId= "3"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Palmer", FieldId= "4"},
                new Venue(){id = new Guid(), RegionCode = "0498", Location = "Palmer", FieldId= "5"},
                new Venue(){id = new Guid(), RegionCode = "1174", Location = "SJ", FieldId= "U10"},
                new Venue(){id = new Guid(), RegionCode = "1174", Location = "SJ", FieldId= "U12"},
                new Venue(){id = new Guid(), RegionCode = "1174", Location = "SJ", FieldId= "U14/16/19"},
                new Venue(){id = new Guid(), RegionCode = "914", Location = "Creekside", FieldId= "Middle"},
                new Venue(){id = new Guid(), RegionCode = "914", Location = "Creekside", FieldId= "U10"},
                new Venue(){id = new Guid(), RegionCode = "778", Location = "Arab", FieldId= "1"},
                new Venue(){id = new Guid(), RegionCode = "778", Location = "Arab", FieldId= "2"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "IP", FieldId= "1"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "IP", FieldId= "2"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "1"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "2"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "3"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "4"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "5"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "6"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "7"},
                new Venue(){id = new Guid(), RegionCode = "160", Location = "JH", FieldId= "8"}
            };
        }

        public SoccerGame createSoccerGame()
        {
            SoccerGame sg = new SoccerGame();
            Random rd = new Random();
            string biologicalGender = _biologicalGenders[rd.Next(0, _biologicalGenders.Count - 1)];
            string division = _divisions[rd.Next(0, _divisions.Count - 1)];
            sg.HomeTeam = createRandomTeam(biologicalGender, division);
            sg.AwayTeam = createRandomTeam(biologicalGender, division);
            sg.GameTime = createRandomSaturday(DateTime.Now, new DateTime(2021, 06, 30));
            sg.GameVenue = _gameVenues[rd.Next(0, _gameVenues.Count - 1)];
            sg.Official = _referees[rd.Next(0, _referees.Count - 1)];
            return sg;
        }

        private string createRandomTeam(string biologicalGender, string division)
        {
            Random rd = new Random();
            string coach = _coaches[rd.Next(0, _coaches.Count - 1)];
            string region = _regions[rd.Next(0, _regions.Count - 1)];
            string id = _teamIds[rd.Next(0, _teamIds.Count - 1)];

            return $"{region}-{division}{biologicalGender}-{id}-{coach}";
        }

        private DateTime createRandomSaturday(DateTime startDate, DateTime endDate)
        {
            DateTime gameDate;

            Random rd = new Random();
            int range = (endDate - startDate).Days;
            int count = 0;
            do
            {
                gameDate = startDate.AddDays(rd.Next(range)).AddHours(8);
                count++;
                if (count > 1000) throw new Exception("WOW! Either the odds are against you getting a random Saturday or your data range is too small.");
            } while (gameDate.DayOfWeek != DayOfWeek.Saturday);
            return gameDate.AddHours(rd.Next(0, 4) * 2);
        }
    }
}
