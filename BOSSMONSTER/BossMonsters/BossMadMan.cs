using BOSSMONSTER.CardGame;

namespace BossMadMan;

class BossMonsterCard : Card
    {
        public int Health { get; set; }
        public int DangerLevel { get; set; }

        public BossMonsterCard(string name, int health, int attack, int reward) : base(name)
        {
            Health = 5;
            DangerLevel = 1;
        }

        public override string GetInfo()
        {
            return 
                $"Name: MadMan\nType: Boss Monster\nHealth: {Health}\nAttack";
        }
    }
