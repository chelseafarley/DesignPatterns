namespace DesignPatterns;

public sealed class Singleton
{
    private static Singleton _instance;
    private int _counter;

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }
    }

    public void IncrementCounter()
    {
        _counter++;
    }

    public void LogCounter()
    {
        Console.WriteLine($"Count: {_counter}");
    }
}

