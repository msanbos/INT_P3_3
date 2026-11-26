using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace InscripcionEstilos;

public partial class EtiquetaCampo : UserControl
{
    public EtiquetaCampo()
    {
        InitializeComponent();
    }
    // Esto permite escribir Etiqueta="..." en MainWindow.axaml
    public string Etiqueta
    {
        get => LblEtiqueta.Text ?? "";
        set => LblEtiqueta.Text = value;
    }

}