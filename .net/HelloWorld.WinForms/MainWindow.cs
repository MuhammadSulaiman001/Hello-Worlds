using HelloWorld.Library;

namespace HelloWorld.WinForms;

public partial class MainWindow : Form
{
    public MainWindow()
    {
        InitializeComponent();
        var greeter = GreetersFactory.GetInstance();
        Banner.Text = greeter.Greet();
    }
}