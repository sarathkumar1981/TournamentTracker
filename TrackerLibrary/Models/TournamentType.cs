namespace TrackerLibrary.Models
{
    public class TournamentType
    {
        public MatchTypes Type { get; set; }

    }

    public enum MatchTypes
    {
        Indoor,
        Outdoor
    }
}