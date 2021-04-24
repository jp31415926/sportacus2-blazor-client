using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestBlazorApp.Data
{
    public class SoccerGame
    {
        public int GameId { get; set; }
        public string Project { get; set; }
        public string Region { get; set; }
        public DateTime GameTime { get; set; }
        public string Status { get; set; }
        public Venue GameVenue { get; set; }
        public int GameLength { get; set; }
        public int SlotLenth { get; set; }
        public int HomeScore { get; set; }
        public int AwayScore { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Official { get; set; }

    }

    public class Venue
    {
        public Guid id { get; set; }
        public string RegionCode { get; set; }
        public string Location { get; set; }
        public string FieldId { get; set; }
        public string SubField { get; set; }

        private string _fullFieldName;

        public string FullFieldName
        {
            get { return $"{RegionCode}-{Location}{FieldId}{SubField}"; }
            set { _fullFieldName = value; }
        }

    }
}
