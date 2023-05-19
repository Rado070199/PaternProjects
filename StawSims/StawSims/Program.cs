using StawSims.DuckBehavior.WayOfFlying;
using StawSims.Ducks;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("ModelDuck");
        Console.WriteLine("");
        Duck modelDuckBlue = new ModelDuck();
        modelDuckBlue.MakeAFlight();
        modelDuckBlue.MakeASound();
        modelDuckBlue.Swim();
        modelDuckBlue.Display();
        modelDuckBlue.SetFlyingIFly(new RocketFlying());
        modelDuckBlue.MakeAFlight();

        Console.WriteLine("RubberyDuck");
        Console.WriteLine("");
        Duck rubberDuckYellow = new RubberDuck();
        rubberDuckYellow.Display();
        rubberDuckYellow.MakeAFlight();
        rubberDuckYellow.MakeASound();
        rubberDuckYellow.SetFlyingIFly(new RocketFlying());
        rubberDuckYellow.MakeAFlight();

        Console.WriteLine("MallardDuck");
        Console.WriteLine("");
        Duck mallardDuckBrown = new MallardDuck();
        mallardDuckBrown.Display();
        mallardDuckBrown.MakeAFlight();
        mallardDuckBrown.MakeASound();
        
    }
}