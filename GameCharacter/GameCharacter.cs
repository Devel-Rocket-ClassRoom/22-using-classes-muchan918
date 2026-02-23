using System;

class GameCharacter
{
    private string name;
    private int level;
    private int maxHp;
    private int currentHp;
    private int attackPower;
    private bool isAlive;

    public string Name { get { return name; } }
    public int Level { get { return level; } }
    public int MaxHp { get { return maxHp; } }
    public int CurrentHp { get { return currentHp; } }
    public int AttackPower { get { return attackPower; } }
    public bool IsAlive { get { return isAlive; } }

    public GameCharacter(string name, int level)
    {
        this.name = name;
        this.level = level;
        this.maxHp = level * 100;
        this.currentHp = MaxHp;
        this.attackPower = level * 10;
        this.isAlive = (CurrentHp > 0) ? true : false;
    }

    public void Attack(GameCharacter target)
    {
        target.TakeDamage(this.AttackPower);
        Console.WriteLine($"{this.name}이(가) {target.name}에게 {this.attackPower} 데미지를 입혔습니다!");
    }

    public void TakeDamage(int damage)
    {
        this.currentHp -= damage;
    }

    public void ShowStatus()
    {
        Console.WriteLine($"[{this.Name}] Lv.{this.Level} - HP: {this.CurrentHp}/{this.MaxHp}, 공격력: {this.AttackPower}");
    }

}