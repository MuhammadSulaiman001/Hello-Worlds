using HelloWorld.Library;

namespace HelloWorld.Test;

[TestClass]
public class GreeterTests
{
    private readonly IGreet _greeter;

    public GreeterTests()
    {
        _greeter = GreetersFactory.GetInstance();
    }

    [TestMethod]
    public void Greet_Should_Return_HelloWorld()
    {
        var message = _greeter.Greet();
        Assert.AreEqual(message, "Hello, World!");
    }
}