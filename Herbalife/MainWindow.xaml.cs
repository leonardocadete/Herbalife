using System.Windows;
using Herbalife.Cadastro;

namespace Herbalife
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            var windowProduto = new Produto();
            windowProduto.Show();
        }
    }
}
