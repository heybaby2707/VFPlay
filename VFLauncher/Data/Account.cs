namespace Data
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public string SessionKey { get; set; }
        public int GMLevel { get; set; }
        public string IP { get; set; }
        public string Language { get; set; }
        public bool Online { get; set; }
        public int IsActive { get; set; }
        public bool Locked { get; set; }
        public int DonatePoint { get; set; }
        public bool IsWoWActive { get; set; }
        public bool IsAionActive { get; set; }
        public int BindClient { get; set; }
        public int WoWClient { get; set; }
        public int AionClient { get; set; }
    }
}