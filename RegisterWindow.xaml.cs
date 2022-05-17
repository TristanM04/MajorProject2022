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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
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


    }
}
