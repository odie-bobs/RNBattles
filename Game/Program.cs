using Game;
using Game.Characters;

var combatant1 = new Warrior(4, 15);
var combatant2 = new Barbarian(8, 17);

var combat = new Combat(combatant1, combatant2);

Console.WriteLine(
    $"{combatant1.GetType().Name} [{combatant1.HitPoints}] vs {combatant2.GetType().Name} [{combatant2.HitPoints}]"
);
Console.WriteLine("----------");

while (combat.CheckForDeath())
{
    combat.Fight();
}

Console.WriteLine(
    !combatant1.IsAlive
        ? $"{combatant1.GetType().Name} wins!"
        : $"{combatant2.GetType().Name} wins!!"
);
