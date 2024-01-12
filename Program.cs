using chooseYourFighter;

Unit player = new Unit(100, 20, 13, "Player");
Unit enemy = new Unit(75, 10, 7, "Enemy Mage");
Random random = new Random();

while (!player.IsDead && !enemy.IsDead)
{
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);
    Console.WriteLine("Player Turn! What will you do?");
    string choice = Console.ReadLine();

    if (choice == "a")
    {
        player.Attack(enemy);
    }
    else
    {
        player.Heal();
    }
    if (enemy.IsDead) break;
    Console.WriteLine(player.UnitName + " HP = " + player.Hp + ". " + enemy.UnitName + " HP = " + enemy.Hp);

    Console.WriteLine("Enemy turn");

    int rand = random.Next(0, 2);
    if (rand == 0)
    {
        enemy.Attack(player);
    }
    else
    {
        enemy.Heal();
    }
    if (player.IsDead) break;
}
Console.WriteLine("You Win!");