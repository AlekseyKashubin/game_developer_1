public class Enemy
{

    public string Name;
    public int Health;
    public List<Attack> AttackList { get; set; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public Attack RandomAttack()
    {
        Random rand = new Random();
        int result = rand.Next(0, AttackList.Count);
        return AttackList[result];
    }

}