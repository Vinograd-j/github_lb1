namespace lab2;

public class Building : GameObject
{

    private bool _isBuilt;

    private int _health;

    public Building(int id, string name, int x, int y, int health) : base(x, y, name, id)
    {
        _health = health;
        _isBuilt = false;
    }

    public void Build()
    {
        _isBuilt = true;
    }

    private void destroy()
    {
        _isBuilt = false;
    }

    public void TakeDamage(int damage)
    {
        if (damage > 0 && _health - damage >= 0) 
            _health -= damage;
        
        if (_health <= 0)
            destroy();
    }
    
}