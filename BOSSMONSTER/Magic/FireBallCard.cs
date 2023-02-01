
namespace BOSSMONSTER;

public class FireBallCard: IMagicCard
{
    public int Damage { get; set; }

    public FireBallCard(string name, int damage) : base(name, "Fire")
    {
        Damage = damage;
    }

    public string GetInfo()
    {
        return $"Name: {Name}\nType: Magic\nType of Magic: {Type}\nDamage: {Damage}";

    }

    public string Name { get; set; }
}