using Game.Attacks;

namespace Game.Interfaces;

public interface ICaster : ICharacter
{
    bool ICharacter.IsHit()
    {
        return Random.Next(0, 100) <= 85;
    }

    bool ICharacter.IsCriticalHit()
    {
        return Random.Next(0, 100) >= 85;
    }

    IHit ICharacter.CreateHit()
    {
        if (!IsHit())
            return new Fireball() { IsHit = false };

        var isCriticalHit = IsCriticalHit();
        var baseDamage = Random.Next(Damage.min, Damage.max);
        var damage = isCriticalHit ? baseDamage * 2 : baseDamage;
        return new Fireball
        {
            IsHit = true,
            IsCritical = isCriticalHit,
            Damage = damage,
        };
    }
}
