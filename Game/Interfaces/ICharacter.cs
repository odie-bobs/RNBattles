namespace Game.Interfaces;

public interface ICharacter
{
    Random Random { get; init; }
    public int HitPoints { get; set; }
    bool IsAlive { get; set; }
    IWeapon Weapon { get; set; }

    public abstract bool IsHit();
    public abstract bool IsCriticalHit();
    public abstract IHit CreateHit();

    public virtual void ApplyHit(IHit hit)
    {
        if (!hit.IsHit)
            return;

        HitPoints -= hit.Damage;
        if (HitPoints <= 0)
            IsAlive = false;
    }

    public virtual void Speak()
    {
        Console.WriteLine("Hello, World!");
    }
}
