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
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace MajorProject2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Uri Source { get; private set; }

        //I have finished working out which versions for all the packages I need to work on for this project and created the correct solution
        //STEP 3: CORRESPOND THE INTERFACE BUTTONS WITH BACKEND METHODS AND CLASSES

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) // Allows the user to drag the window around the screen for accessibiity
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        
        public void GrantAccess() // Shows the Home page after logging in with the correct details
        {
            TestHomePage main = new TestHomePage();
            main.Show();
            using (UserDataContext context = new UserDataContext())
            {
                // Save user ID as a variable3
            }
        }

        public static class Globals
        {
            public static int primaryKey;
        }
        private void Button_Click(object sender, RoutedEventArgs e) //Click the login button
        {
            var UserName = UsernameBox.Text;
            var PassWord = PasswordBox.Password;
            

            using (UserDataContext context = new UserDataContext())
            {
                bool userfound = context.User.Any(user => user.Name == UserName && user.Password == PassWord); //Checks to see if the details exist

                if (userfound)
                {
                    User foundUser = context.User.FirstOrDefault(a => a.Name == UserName); //get a matching record based on the condition. If no matching record is found, the default value of null will be returned.
                    if (null != foundUser)                                                 //since we have already found the name, it will always return the id
                    {
                        Globals.primaryKey = foundUser.Id; // Saves the users ID as a global variable
                    }
                    GrantAccess(); //Brings the user to the main page
                    Close();


                } else
                {
                    MessageBox.Show("User Not Found");
                }
            }
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

        private void Button_Click_1(object sender, RoutedEventArgs e) // Brings the user to the register window
        {
            RegisterWindow register = new RegisterWindow();
            register.Show();
            Close();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        } //Exit button
    }
}
