using Game.Interfaces;

namespace Game;

public class BasicHit(IWeapon weapon) : IHit
{
    public bool IsHit { get; set; }
    public bool IsCritical { get; set; }
    public int Damage
    {
        get => CalculateDamage();
    }

    public int CalculateDamage()
    {
        var damage = (int)
            Math.Floor(weapon.Random.Next(weapon.MinDamage, weapon.MaxDamage) / weapon.Speed);

        return IsCritical ? damage * 2 : damage;
    }
}
