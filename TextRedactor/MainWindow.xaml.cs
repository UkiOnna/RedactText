using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TextRedactor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string paste;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CutClick(object sender, RoutedEventArgs e)
        {
            if (Text.SelectedText == string.Empty)
            {

            }
            else
            {
                paste = Text.SelectedText;
                Text.SelectedText = "";
            }
        }

        private void PasteClick(object sender, RoutedEventArgs e)
        {
            Text.SelectedText = Text.SelectedText+paste;
        }

        private void CopyClick(object sender, RoutedEventArgs e)
        {
            if (Text.SelectedText == string.Empty)
            {

            }
            else
            {
                paste = Text.SelectedText;
            }
        }
    }
}
