namespace lab2;

public class MobileHome : Building, Moveable
{

    private int _speed;
    
    public MobileHome(int speed, int health, int id, string name, int x, int y) : base(id, name, x, y, health)
    {
        _speed = speed;
    }
    
    public void Move(int x, int y)
    {
        UpdatePosition(x * _speed, y * _speed);
    }

    public void Sprint(int x, int y)
    {
        UpdatePosition(x * 2 * _speed, y * 2 * _speed);
    }
    
}