using System.Numerics;

namespace lab2;

public class Archer : Unit, Moveable, Attacker
{
    private int _arrowsCount;

    private int _strength;
    
    public Archer(float health, bool isAlive, int id, string name) : base(health, isAlive, id, name)
    {
        _arrowsCount = 100;
        _strength = 1;
    }

    public void Move(int x, int y)
    {
        UpdatePosition(x, y);
    }

    public void IncreaseStrength()
    {
        _strength++;
    }

    public void RefillArrows()
    {
        _arrowsCount = 100;
    }
    
    public void Attack(Unit unit)
    {
        if (_arrowsCount > 0)
        {
            unit.ReceiveDamage(_strength);
            _arrowsCount--;
        }
    }
    
}