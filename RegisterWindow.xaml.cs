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
using System.Globalization;
using System.Text.RegularExpressions;

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

        public static bool RegexEmailCheck(string email) // returns true if the input is a valid email
        {
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
        public void Create() // Creates a new user and add it to the database
        {
            using (UserDataContext context = new UserDataContext())
            {
                var UserName = UsernameBox.Text;
                var PassWord = PasswordBox.Password;
                string email = EmailBox.Text;

                if (UserName != null && PassWord != null && email != null && UserName != "Username" && email != "Email") //Make sure all fields are filled
                {
                    if (RegexEmailCheck(email)) //Calls the Email checker function
                    {
                        if (context.User.Any(User => User.Name == UserName || User.Email == email)) //Checks to make sure the users details does not already exist
                        {
                            MessageBox.Show("User already exists");
                        }
                        else
                        {
                            context.User.Add(new User() { Name = UserName, Password = PassWord, Email = email }); //If it doesnt exist, then create the user
                            context.SaveChanges(); //exception 
                            MessageBox.Show("Created new user!");
                        }
                    } else
                    {
                        MessageBox.Show("Invalid Email address");
                    }
                } 
                else
                {
                    MessageBox.Show("Please fill all fields");
                }
            }
        }

        private void RegisterClick(object sender, RoutedEventArgs e) //Register Button in the register window
        {
            Create(); //This calls the Create method, and makes a new user in the databse
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
