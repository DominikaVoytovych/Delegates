    using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.FontWeight = FontWeights.Bold;

            WrapPanel pnl = new WrapPanel();
            //btn.Content = "Красотка :)";
            TextBlock txt = new TextBlock();
            txt.Text = "Натисни";
            txt.Padding = new Thickness(10);
            txt.Foreground = Brushes.Blue;
            pnl.Children.Add(txt);

            btn.Content = pnl;

            myGrid.Children.Add(btn);
        }
    }
}