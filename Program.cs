// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");





Attack water = new Attack("Water Blast", 24);
Attack ice = new Attack("Freeze", 19);
Attack fire = new Attack("Fire Ball", 20);


List<Attack> Attacks= new List<Attack>();
Attacks.Add(water);
Attacks.Add(ice);
Attacks.Add(fire);

Enemy troll = new Enemy("Frost Troll");
Enemy giant = new Enemy("White Giant");


List<Attack> EnemyAttacks= new List<Attack>()
{
    water,
    ice,
    fire
};

troll.AttackList = EnemyAttacks; 

Console.WriteLine(troll.RandomAttack().Name);
