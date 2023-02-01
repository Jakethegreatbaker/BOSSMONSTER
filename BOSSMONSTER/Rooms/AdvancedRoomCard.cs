namespace BOSSMONSTER;

class AdvancedRoomCard : RoomCard
{
    public int Traps { get; set; }

    public AdvancedRoomCard(string name, int dangerLevel, int reward, int traps) : base(name, dangerLevel, reward)
    {
        Traps = traps;
    }

    public override string GetInfo()
    {
        return 
            $"Name: {Name}\nType: Advanced Room\nDanger Level: {DangerLevel}\nTraps: {Traps}";
    }
}