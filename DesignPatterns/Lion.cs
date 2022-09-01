namespace DesignPatterns;

public class Lion : HungryThing
{
    public override void CleanUp()
    {
        Console.WriteLine("Lick paws");
    }

    public override void EatFood()
    {
        Console.WriteLine("Rip into it with teeth");
    }

    public override void GatherFood()
    {
        Console.WriteLine("Hunt prey... Ooh a zebra!");
    }
}

