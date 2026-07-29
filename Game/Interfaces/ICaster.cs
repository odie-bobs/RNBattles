namespace Game.Interfaces;

public interface ICaster : ICharacter
{
    protected abstract IHit CreateSpell();

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
        var spell = CreateSpell();

        if (!IsHit())
        {
            spell.IsHit = false;
            return spell;
        }

        var isCriticalHit = IsCriticalHit();
        var baseDamage = Random.Next(Damage.min, Damage.max);
        var damage = isCriticalHit ? baseDamage * 2 : baseDamage;

        spell.IsHit = true;
        spell.IsCritical = isCriticalHit;
        spell.Damage = damage;

        return spell;
    }
}
