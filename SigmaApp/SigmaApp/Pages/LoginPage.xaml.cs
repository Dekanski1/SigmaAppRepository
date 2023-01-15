using System.Windows;
using System.Windows.Controls;

namespace SigmaApp
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginCloseButton(object sender, System.Windows.RoutedEventArgs e)
        {
            App.Current.Shutdown();

        }

        private void LoginNextPageButton (object sender, System.Windows.RoutedEventArgs e)
        {
            NextPage np = new NextPage();
            MainWindow m = new MainWindow();
            m.Content = np;
            m.Show();

            Window parentWindow = Window.GetWindow(this);
            parentWindow.Close();

            

        }
    }
}
