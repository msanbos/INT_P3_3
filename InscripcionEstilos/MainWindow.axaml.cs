using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace InscripcionEstilos;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TemaSwitch_IsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (Application.Current is null) return;

        Application.Current.RequestedThemeVariant =
            TemaSwitch.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}