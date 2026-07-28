using Game.Attacks;
using Game.Interfaces;

namespace Game.Characters;

public class FireMage(int min, int max) : ICaster
{
    public Random Random { get; init; } = new();
    public int HitPoints { get; set; } = 100;
    public bool IsAlive { get; set; } = true;
    public (int min, int max) Damage { get; set; } = (min, max);

    IHit ICaster.CreateSpell() => new Fireball();
}
