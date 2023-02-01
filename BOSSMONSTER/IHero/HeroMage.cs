namespace BOSSMONSTER;

public class HeroMage
{
    public class Mage : IHeroCard
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }

        public Mage(string name, int health, int attack)
        {
            Name = "Randolph the Red";
            Health = 7;
            Attack = 1;
        }

        public string GetInfo()
        {
            return $"Name: {Name}\nType: Mage\nHealth: {Health}\nAttack: {Attack}";
        }
    }
}