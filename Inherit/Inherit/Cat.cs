public class Cat : Animal
{
    public Cat()
    {
        name = "Cat";   
    }
    public void Say()
    {
        stamina--;
        Console.WriteLine("Meow");
    }

    public override void Eat()
    {
        Say();
        base.Eat();
        Say();
    }
}
