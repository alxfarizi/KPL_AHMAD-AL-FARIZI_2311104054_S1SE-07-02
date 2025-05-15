using Avalonia.Controls;

namespace tpmodul12_2311104054
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCheckButtonClick(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            if (int.TryParse(InputTextBox.Text, out int number))
            {
                OutputLabel.Text = CariTandaBilangan(number);
            }
            else
            {
                OutputLabel.Text = "Input tidak valid!";
            }
        }

        public string CariTandaBilangan(int number)
        {
            var helper = new BilanganHelper();
            return helper.CariTandaBilangan(number);
        }
    }
}
