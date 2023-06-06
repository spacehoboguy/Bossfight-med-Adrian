using Bossfight_med_Adrian;

InitializeFight();

void InitializeFight()
{
    Console.WriteLine("Enter showdown");
    Console.WriteLine("Character Name:");
    string? inputName = Console.ReadLine();
    GameCharacter boss = new GameCharacter("EvilBoss", 400, 30, 10);
    GameCharacter hero = new GameCharacter(inputName, 100, 20, 40);
    

    hero.Fight(boss);
    boss.Fight(hero);
    hero.Fight(boss);
    boss.Recharge(boss);
}
