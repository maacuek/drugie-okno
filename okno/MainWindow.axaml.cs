using Avalonia.Controls;
using Avalonia.Interactivity;

namespace okno;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnWyjscieClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }
}