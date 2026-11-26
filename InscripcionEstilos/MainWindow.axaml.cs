using System; /*Para que funcione DateTime*/
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Styling;

namespace InscripcionEstilos;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();                 // primero: crea los controles del .axaml
    
        var etiqueta = new TextBlock           // la etiqueta dinámica
        {
            Text = "Formulario abierto el " + DateTime.Now.ToString("dd/MM/yyyy"),
            FontSize = 12,
            Margin = new Thickness(0, 8, 0, 0)
        };
        // etiqueta.Classes.Add("ayuda");      // opcional: aplicar un estilo tuyo
    
        PanelFormulario.Children.Add(etiqueta); // al final: para que se vea
        
        Title = "Inscripción · " + DateTime.Now.Year;   // título de la ventana
        CursoComboBox.SelectedIndex = 0;                 // curso preseleccionado


    }

    private void TemaSwitch_IsCheckedChanged(object? sender, RoutedEventArgs e)
    {
        if (Application.Current is null) return;

        Application.Current.RequestedThemeVariant =
            TemaSwitch.IsChecked == true ? ThemeVariant.Dark : ThemeVariant.Light;
    }
}