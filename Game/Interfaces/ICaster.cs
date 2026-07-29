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

        spell.IsHit = IsHit();

        if (spell.IsHit)
            spell.IsCritical = IsCriticalHit();

        return spell;
    }
}
