namespace KuzushiService
{
    public class Gym
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public Gym(string name, string location)
        {
            Name = name;
            Location = location;
        }
    }
}
