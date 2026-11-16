namespace lab2;

public class Unit : GameObject
{

    private bool _isAlive;

    private float _health;

    public Unit(float health, bool isAlive, int id, string name) : base(0, 0, name, id)
    {
        _health = health;
        _isAlive = isAlive;
    }

    public bool IsAlive()
    {
        return _isAlive;
    }

    public float GetHp()
    {
        return _health;
    }

    public void ReceiveDamage(float damage)
    {
        if (damage > 0 && _health - damage >= 0)
            _health -= damage;
    }
    
}