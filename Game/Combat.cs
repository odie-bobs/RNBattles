using Game.Interfaces;

namespace Game;

public class Combat(ICharacter character1, ICharacter character2)
{
    public void Fight()
    {
        RunHit(character1, character2);
        RunHit(character2, character1);
    }

    public bool CheckForDeath()
    {
        return character1.IsAlive && character2.IsAlive;
    }

    private void RunHit(ICharacter attacker, ICharacter target)
    {
        if (!attacker.IsAlive)
            return;

        var hit = attacker.CreateHit();
        target.ApplyHit(hit);
        AnnounceHit(hit, attacker, target);
    }

    private static void AnnounceHit(IHit hit, ICharacter attacker, ICharacter target)
    {
        var attackerName = attacker.GetType().Name;
        var targetName = target.GetType().Name;
        var hitName = hit.GetType().Name.ToLower();

        var message = string.Empty;
        if (!hit.IsHit)
        {
            message =
                $"{attackerName}'s {hitName} misses {targetName}. [{target.GetType().Name}: {target.HitPoints}]";
        }
        else if (hit.IsCritical)
        {
            message =
                $"{attackerName}'s {hitName} CRITICALLY hits {targetName} for {hit.Damage} damage. [{target.GetType().Name}: {target.HitPoints}]";
        }
        else
        {
            message =
                $"{attackerName}'s {hitName} hit {targetName} for {hit.Damage} damage. [{targetName}: {target.HitPoints}]";
        }

        Console.WriteLine(message);
    }
}
