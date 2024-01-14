using HelloWorld.Library;

namespace HelloWorld.WPF;

public class MainWindowViewModel
{
    public MainWindowViewModel()
    {
        var greeter = GreetersFactory.GetInstance();
        Banner = greeter.Greet();
    }

    public string Banner { get; }
}