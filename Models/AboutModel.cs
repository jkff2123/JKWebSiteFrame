namespace WebSiteFrame.Models
{
    public class AboutModel
    {
        public AboutModel(int index, string name, string position, string description, byte[] picture)
        {
            Index = index;
            Name = name;
            Position = position;
            Description = description;
            Picture = picture;
        }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Description { get; set; }
        public byte[] Picture { get; set; }
    }
}
