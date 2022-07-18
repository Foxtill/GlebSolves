public class Hawk : Bird, IFlying
{
    void IFlying.Fly()
    {
        Console.WriteLine("Hawk Fly");
    }
}   