namespace lab2;

public class Fort : Building, Attacker
{
    
    private int _strength;
    
    public Fort(int id, string name, int strength, int x, int y, int health) : base(id, name, x, y, health)
    {
        _strength = strength;
    }

    public void Attack(Unit unit)
    {
        unit.ReceiveDamage(_strength);
    }
    
}