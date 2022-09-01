using DesignPatterns;



// Singleton
void SingletonExample()
{
    Singleton mySingleton = Singleton.Instance;
    mySingleton.IncrementCounter();
    mySingleton.IncrementCounter();
    mySingleton.LogCounter();

    Singleton singleton2 = Singleton.Instance;
    singleton2.LogCounter();

    singleton2.IncrementCounter();
    singleton2.LogCounter();
    mySingleton.LogCounter();
}

// Template Method
void TemplateExample()
{
    Human h = new Human();
    h.ItsFoodTime();

    Lion l = new Lion();
    l.ItsFoodTime();
}