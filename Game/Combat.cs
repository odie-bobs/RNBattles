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
        if (!attacker.IsAlive) return;
        
        var hit = attacker.CreateHit();
        target.ApplyHit(hit);
        AnnounceHit(hit, attacker, target);
    }

    private static void AnnounceHit(IHit hit, ICharacter attacker, ICharacter target)
    {
        var message = string.Empty;
        if (!hit.IsHit)
        {
            message = $"{attacker.GetType().Name}'s hit misses {target.GetType().Name}. [{target.GetType().Name}: {target.HitPoints}]";
        }
        else if (hit.IsCritical)
        {
            message = $"{attacker.GetType().Name} CRITICALLY hits {target.GetType().Name} for {hit.Damage} damage. [{target.GetType().Name}: {target.HitPoints}]";
        }
        else
        {
            message = $"{attacker.GetType().Name} hits {target.GetType().Name} for {hit.Damage} damage. [{target.GetType().Name}: {target.HitPoints}]";
        }

        Console.WriteLine(message);
    }
}