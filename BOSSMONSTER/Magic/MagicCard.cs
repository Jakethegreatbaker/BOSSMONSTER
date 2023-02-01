namespace BOSSMONSTER;

public class IMagicCard : ICard
{
    public string Type { get; set; }

    public IMagicCard(string name, string type)
    {
        Name = name;
        Type = type;
    }

    public string Name { get; set; }
    public int Health { get; set; } = 0;
    public int Attack { get; set; } = 0;

    public string GetInfo()
    {
        return $"Name: {Name}\nType: Magic\nType of Magic: {Type}";
    }
}