namespace HelloWorld.Library;

public interface IGreet
{
    string Greet();
}

public class Greeter : IGreet
{
    public string Greet()
    {
        return "Hello, World!";
    }
}

public static class GreetersFactory
{
    public static IGreet GetInstance() => new Greeter();
}