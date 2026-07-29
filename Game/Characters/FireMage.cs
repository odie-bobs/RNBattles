using Game.Hits.Spells;
using Game.Interfaces;

namespace Game.Characters;

public class FireMage(IWeapon weapon) : ICaster
{
    public Random Random { get; init; } = new();
    public int HitPoints { get; set; } = 100;
    public bool IsAlive { get; set; } = true;
    public IWeapon Weapon { get; set; } = weapon;

    IHit ICaster.CreateSpell() => new Fireball(Weapon);
}
