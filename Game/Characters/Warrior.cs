using Game.Hits.Attacks;
using Game.Interfaces;

namespace Game.Characters;

public class Warrior(IWeapon weapon) : IMelee
{
    public Random Random { get; init; } = new();
    public int HitPoints { get; set; } = 125;
    public bool IsAlive { get; set; } = true;
    public IWeapon Weapon { get; set; } = weapon;

    public IHit CreateAttack() => new Strike(Weapon);
}
