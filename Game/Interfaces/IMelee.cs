namespace Game.Interfaces;

public interface IMelee : ICharacter
{
    public abstract IHit CreateAttack();

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
        var Attack = CreateAttack();

        Attack.IsHit = IsHit();

        if (Attack.IsHit)
        {
            Attack.IsCritical = IsCriticalHit();
            var baseDamage = Random.Next(Damage.min, Damage.max);
            Attack.Damage = Attack.IsCritical ? baseDamage * 2 : baseDamage;
        }

        return Attack;
    }
}
