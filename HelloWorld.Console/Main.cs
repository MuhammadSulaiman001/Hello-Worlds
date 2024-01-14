using HelloWorld.Library;

var greeter = GreetersFactory.GetInstance();
var message = greeter.Greet();
Console.WriteLine(message);
Console.ReadKey();