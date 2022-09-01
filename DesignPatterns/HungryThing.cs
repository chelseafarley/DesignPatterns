namespace DesignPatterns;

public abstract class HungryThing
{
    public abstract void GatherFood();
    public abstract void EatFood();
    public abstract void CleanUp();

    public void ItsFoodTime()
    {
        GatherFood();
        EatFood();
        CleanUp();
    }
}

