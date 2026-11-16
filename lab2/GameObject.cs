namespace lab2;

public abstract class GameObject
{
    private int _x;

    private int _y;
    
    private string _name;

    private int _id;

    public GameObject(int x, int y, string name, int id)
    {
        _x = x;
        _y = y;
        _name = name;
        _id = id;
    }

    protected void UpdatePosition(int x, int y)
    {
        _x = x;
        _y = y;
    } 

    public int GetX()
    {
        return _x;
    }

    public int GetY()
    {
        return _y;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetId()
    {
        return _id;
    }
    
}