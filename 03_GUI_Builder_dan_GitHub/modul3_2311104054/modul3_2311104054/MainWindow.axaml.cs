using Avalonia.Controls;
using Avalonia.Interactivity;

namespace modul3_2311104054
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button btn)
            {
                txtDisplay.Text += btn.Content.ToString();
            }
        }

        private void BtnClear(object sender, RoutedEventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void BtnCalculate(object sender, RoutedEventArgs e)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(txtDisplay.Text, null);
                txtDisplay.Text = result.ToString();
            }
            catch
            {
                txtDisplay.Text = "Error";
            }
        }
    } 
}  