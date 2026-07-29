using Game.Hits.Attacks;
using Game.Interfaces;

namespace Game.Characters;

public class Barbarian(int min, int max) : IMelee
{
    public Random Random { get; init; } = new();
    public int HitPoints { get; set; } = 95;
    public bool IsAlive { get; set; } = true;
    public (int min, int max) Damage { get; set; } = (min, max);

    IHit IMelee.CreateAttack() => new Slam();
}
