namespace KuzushiService
{
    public class TournamentEvent
    {

        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime EventDate { get; set; }
        public List<User>? Fighters { get; set; }

        public TournamentEvent(string name, string type, DateTime eventDate, List<User>? fighters)
        {
            Name = name;
            Type = type;
            EventDate = eventDate;
            Fighters = fighters;
        }
    }
}
