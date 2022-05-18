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
using System.Windows.Shapes;

namespace MajorProject2022
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e) //LETS THE WINDOW BE DRAGGED AROUND
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Login Button on register window
        {
            MainWindow login = new MainWindow();
            login.Show();
            Close();
        }

        private void TextBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the text box
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Username")
                txtBox.Text = string.Empty;
        }

        private void Password_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the password box
        {
            PasswordBox PassBox = sender as PasswordBox;
            if (PassBox.Password == "Password")
                PassBox.Password = string.Empty;
        }

        private void EmailBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the email box
        {
            TextBox EmailBox = sender as TextBox;
            if (EmailBox.Text == "Email")
                EmailBox.Text = string.Empty;
        }

        public void Create()
        {
            using (UserDataContext context = new UserDataContext())
            {
                var username = UsernameBox.Text;
                var password = PasswordBox.Password;
                var email = EmailBox.Text;

                if (username != null && password != null && email != null)
                {
                    context.Users.Add(new User() { Name = username, Password = password, Email = email });
                    context.SaveChanges(); //exception
                }
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e) //Register Button in the register window
        {
            Create(); //This calls the Create method, and makes a new user in the databse
        }
    }
}
