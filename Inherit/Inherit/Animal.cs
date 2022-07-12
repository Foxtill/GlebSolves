public class Animal
{
    // сытость
    public string name = "Animal";
    public int stamina;
    public int speed;
    public virtual void Eat()
    {
        stamina++;
        Console.WriteLine(name + " stamina = " + stamina);
    }
    public void Move()
    {
        speed = 5;
        Console.WriteLine(name + " speed = " + speed);
    }
}
