namespace KuzushiService
{
    public class User
    {
        public string Name { get; set; }
        public string Rank { get; set; }

        public User(string name, string rank)
        {
            Name = name;
            Rank = rank;
        }
    }
}