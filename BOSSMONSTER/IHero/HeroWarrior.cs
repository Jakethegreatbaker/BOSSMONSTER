namespace BOSSMONSTER;

public class HeroWarrior
{
    public class Warrior : IHeroCard
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Reward { get; set; }

        public Warrior(string name, int health, int attack)
        {
            Name = "JERRY...or is it Gary?";
            Health = 5;
            Attack = 1;
            Reward = 1;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\nType: Warrior\nHealth: {Health}\nAttack: {Attack}";
        }
    }
}