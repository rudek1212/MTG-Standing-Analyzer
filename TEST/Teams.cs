using System;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace TEST
{
    [XmlRoot(ElementName = "Team")]
    public class Team
    {
        [XmlAttribute(AttributeName = "Rank")]
        public string Rank { get; set; }
        [XmlAttribute(AttributeName = "Name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "DCI")]
        public string DCI { get; set; }
        [XmlAttribute(AttributeName = "MatchPoints")]
        public string MatchPoints { get; set; }
        [XmlAttribute(AttributeName = "MatchResultsPWDB")]
        public string MatchResultsPWDB { get; set; }
        [XmlAttribute(AttributeName = "OpponentMatchWinPercent")]
        public string OpponentMatchWinPercent { get; set; }
        [XmlAttribute(AttributeName = "GamesWinPercent")]
        public string GamesWinPercent { get; set; }
        [XmlAttribute(AttributeName = "OpponentsGameWinPercent")]
        public string OpponentsGameWinPercent { get; set; }
    }

    [XmlRoot(ElementName = "Standings")]
    public class Standings
    {
        [XmlElement(ElementName = "Team")]
        public List<Team> Team { get; set; }
    }

}
