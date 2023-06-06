namespace Bossfight_med_Adrian;

public class GameCharacter
{
    public string? Name { get; set; }

    public int Health { get; set; } 

    public int Strength { get; set; }

    public int Stamina { get; set; }

    //IMAN NOTES: Trekke ut changeHealth(this) fra fight i en egen methode. 
    //Bruke .this 

    public GameCharacter(string? name, int health, int strength, int stamina)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Stamina = stamina;
    }

    public void Fight(GameCharacter fiende)
    {
        if (Stamina > 0)
        {
            Stamina -= 10;
            var fiendeHealth = fiende.Health - Strength;
            fiende.Health = fiendeHealth;
            Console.WriteLine($"{Name} attacked {fiende.Name} for {Strength}HP, {fiende.Name} has {fiende.Health}HP' remaining.");
        }
        else
        {
            //Recharge(); 
            Console.WriteLine("Stamina must be recharged to fight on!");
        }
    }

    public void Recharge(GameCharacter charToCharge)
    {
        if (charToCharge.Name == "EvilBoss")
        {
            Stamina += 10;
            Console.WriteLine($"{Name} recharged stamina to {Stamina}");
        }
        else
        {
            Stamina += 40;
            Console.WriteLine($"{Name} recharged stamina to {Stamina}");
        }
    }
}