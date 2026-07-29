using Game.Hits.Attacks;
using Game.Interfaces;

namespace Game.Characters;

public class Barbarian(IWeapon weapon) : IMelee
{
    public Random Random { get; init; } = new();
    public int HitPoints { get; set; } = 95;
    public bool IsAlive { get; set; } = true;
    public IWeapon Weapon { get; set; } = weapon;

    IHit IMelee.CreateAttack() => new Slam(Weapon);
}
