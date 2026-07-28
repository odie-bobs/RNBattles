using Game.Interfaces;

namespace Game.Attacks;

public class Fireball : IHit
{
    public bool IsHit { get; set; }
    public bool IsCritical { get; set; }
    public int Damage { get; set; }
}
