public class Main
{
    public void Start()
    {
        Hawk hawk = new Hawk();
        ((IFlying)hawk).Fly();
        hawk.Fly();
        hawk.Peck();

        Chafer chafer = new Chafer();
        chafer.Fly();

        Ant ant = new Ant();
        // муравей не летает ((((
    }
}