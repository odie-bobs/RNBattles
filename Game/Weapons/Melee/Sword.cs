using Game.Interfaces;

namespace Game.Weapons.Melee;

public class Sword(int minDamage, int maxDamage, double speed) : IWeapon
{
    public Random Random { get; init; } = new();
    public int MinDamage { get; set; } = minDamage;
    public int MaxDamage { get; set; } = maxDamage;
    public double Speed { get; init; } = speed;

    public double Attack()
    {
        return 0;
    }
}
