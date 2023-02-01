namespace BOSSMONSTER;

public interface IHeroCard
{
    string Name { get; set; }
    int Health { get; set; }
    int Attack { get; set; }

    string GetInfo();
}