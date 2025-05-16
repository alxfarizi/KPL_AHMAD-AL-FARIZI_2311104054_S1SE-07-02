using Avalonia.Controls;
using System;
using Modul12_Lib;

namespace Modul12_GUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnHitungClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        if (int.TryParse(InputA.Text, out int a) && int.TryParse(InputB.Text, out int b))
        {
            int result = PangkatHelper.CariNilaiPangkat(a, b);
            OutputLabel.Text = $"Hasil: {result}";
        }
        else
        {
            OutputLabel.Text = "Masukkan input valid (angka bulat)";
        }
    }
}
