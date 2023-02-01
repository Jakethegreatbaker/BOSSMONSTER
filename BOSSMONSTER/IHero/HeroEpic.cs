namespace BOSSMONSTER;

public class HeroEpic
{
    public class HeroEpic : IHeroCard
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public HeroEpic(string name, int health, int attack)
        {
            Name = "THE HERO";
            Health = 10;
            Attack = 3;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\nType: Warrior\nHealth: {Health}\nAttack: {Attack}";
        }
    }
}