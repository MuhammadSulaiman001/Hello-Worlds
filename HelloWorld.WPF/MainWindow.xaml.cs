﻿namespace HelloWorld.WPF;

public partial class MainWindow
{
    public MainWindow()
    {
        DataContext = new MainWindowViewModel();
        InitializeComponent();
    }
}