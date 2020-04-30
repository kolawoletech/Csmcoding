using System.Runtime.Serialization;

namespace sm_coding_challenge.Models
{
    [DataContract]
    public class LatestPlayerModel
    {
        [DataMember(Name = "player_id")]
        public string Id { get; set; }

        [DataMember(Name = "entry_Id")]
        public string Entry_Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "recs")]
        public string Records { get; set; }

        [DataMember(Name = "position")]
        public string Position { get; set; }

        [DataMember(Name = "yds")]
        public string Yards { get; set; }


        [DataMember(Name = "att")]
        public string Attribute { get; set; }

        [DataMember(Name = "tds")]
        public string Touchdowns { get; set; }

        [DataMember(Name = "fum")]
        public string Fumble { get; set; }
    }


}

