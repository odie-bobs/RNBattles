using Game;
using Game.Characters;
using Game.Weapons.Melee;

var combatant1 = new Warrior(new Sword(15, 35, 2.25));
var combatant2 = new Barbarian(new Sword(10, 25, 1.2));

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
    combatant1.IsAlive
        ? $"{combatant1.GetType().Name} wins!"
        : $"{combatant2.GetType().Name} wins!!"
);
