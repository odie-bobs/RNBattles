namespace Game.Interfaces;

public interface IHit
{
    public bool IsHit { get; set; }
    public bool IsCritical { get; set; }
    public int Damage { get; }

    public int CalculateDamage();
}
