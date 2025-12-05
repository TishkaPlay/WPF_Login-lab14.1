using System.Windows;
using System.Windows.Controls;


namespace WPF_Login
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);
            window.Content = new InvoiceView();
        }
    } 
}
