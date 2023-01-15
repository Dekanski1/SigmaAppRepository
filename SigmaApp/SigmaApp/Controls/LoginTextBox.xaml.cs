using System;
using System.Windows;
using System.Windows.Controls;

namespace SigmaApp
{
    /// <summary>
    /// Interaction logic for LoginTextBox.xaml
    /// </summary>
    public partial class LoginTextBox : UserControl
    {
        public LoginTextBox()
        {
            InitializeComponent();
        }



        public String PlaceHolder
        {
            get { return (String)GetValue(PlaceHolderProperty); }
            set { SetValue(PlaceHolderProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlaceHolder.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register("PlaceHolder", typeof(String), typeof(LoginTextBox));


        public String Text
        {
            get { return (String)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(String), typeof(LoginTextBox));




        public bool IsPasswoed
        {
            get { return (bool)GetValue(IsPasswoedProperty); }
            set { SetValue(IsPasswoedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsPasswoed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsPasswoedProperty =
            DependencyProperty.Register("IsPasswoed", typeof(bool), typeof(LoginTextBox));


        private void passbox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            login.Text = passbox.Password;
        }




    }
}
