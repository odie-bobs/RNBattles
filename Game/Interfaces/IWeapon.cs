namespace Game;

public interface IWeapon
{
    public Random Random { get; init; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; }
    public double Speed { get; init; }
    public abstract double Attack();
}
