namespace BOSSMONSTER;

public class RoomCard : ICard
{
    public string Name { get; set; }
    public int DangerLevel { get; set; }
    public int Attack { get; set; }

    public RoomCard(string name, int dangerLevel, int reward)
    {
        Name = name;
        DangerLevel = dangerLevel; 
            //Danger level to draw in heroes?
                //Maybe epics are not interested in low level dungeons?
        Attack = Attack;
    }

    public virtual string GetInfo()
    {
        return $"Name: {Name}\nType: Room\nDanger Level: {DangerLevel}\nReward: {Reward}";
    }
}
