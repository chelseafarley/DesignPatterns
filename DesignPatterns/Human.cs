namespace DesignPatterns;

public class Human : HungryThing
{
    public override void CleanUp()
    {
        Console.WriteLine("Wash hands and dishes");
    }

    public override void EatFood()
    {
        Console.WriteLine("Eat with knives and forks");
    }

    public override void GatherFood()
    {
        Console.WriteLine("Go to fridge and prepare meal");
    }
}

