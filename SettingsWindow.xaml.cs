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
using static MajorProject2022.MainWindow;
using System.Security.Cryptography;

namespace MajorProject2022
{
    /// <summary>
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
            Read();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        } //Allows the window to be moved around

        private void Workout_MouseEnter(object sender, MouseEventArgs e)
        {

        } //Hover over animation method

        private void Workout_MouseLeave(object sender, MouseEventArgs e)
        {

        }//Hover over animation method

        private void Chat_MouseEnter(object sender, MouseEventArgs e)
        {

        }//Hover over animation method

        private void Chat_MouseLeave(object sender, MouseEventArgs e)
        {

        }//Hover over animation method

        private void Settings_MouseEnter(object sender, MouseEventArgs e)
        {

        }//Hover over animation method

        private void Settings_MouseLeave(object sender, MouseEventArgs e)
        {

        }//Hover over animation method

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        } // Exit button

        private void Confirm_Click(object sender, RoutedEventArgs e) // Confirms changing personal details
        {
            Create();
        }

        private void Workout_Click(object sender, RoutedEventArgs e) //Goes back to the workout page
        {
            TestHomePage workout = new TestHomePage();
            workout.Show();
            Close();
        }

        private void EmailBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox EmailBox = sender as TextBox;
            if (EmailBox.Text == "Email")
                EmailBox.Text = string.Empty;
        } // Makes text in text box dissappear on click

        private void UsernameBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox UsernameBox = sender as TextBox;
            if (UsernameBox.Text == "Username")
                UsernameBox.Text = string.Empty;
        } // Makes text in text box dissappear on click

        private void PasswordBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            PasswordBox PasswordBox = sender as PasswordBox;
            if (PasswordBox.Password == "Password")
                PasswordBox.Password = string.Empty;
        } // Makes text in text box dissappear on click

        public void Read() // Display's the user's current personal details
        {
            EmailBox.Text = Globals.eMail; //Stores the logged in user's email into the email box
            UsernameBox.Text = Globals.userName; //Stores the logged in user's name into the username box

            string dottedpassword = "";

            for (int i = 0;i < Globals.passWord.Length; i++) 
            {
                dottedpassword = dottedpassword + "●";
            }

            PasswordBox.Text = dottedpassword; //Stores the logged in user's password into the password box
        }

        public void Create() // The method to update the user's details in the database
        {
            var newEmail = NewEmailBox.Text;
            var newUsername = NewUsernameBox.Text;
            var newPassword = NewPasswordBox.Password;

            var hasher = new SHA256Managed(); //Calls the hashing function
            var unhashed = System.Text.Encoding.Unicode.GetBytes(newPassword); //Converts the password into a byte array
            var hashed = hasher.ComputeHash(unhashed); //Hashes the byte array with the hashing function
            var hashedPassword = Convert.ToBase64String(hashed); //Converts the hashed byte array back into a string

            using (UserDataContext context = new UserDataContext())
            {
                User user = context.User.Find(Globals.primaryKey);
                user.Email = newEmail;
                user.Name = newUsername;
                user.Password = hashedPassword;
                context.SaveChanges();
            }

            Globals.eMail = newEmail;
            Globals.userName = newUsername;
            Globals.passWord = newPassword;
        }

        private void NewRefresh_Click(object sender, RoutedEventArgs e) // Refreshes the page, displaying the updated details
        {
            Read();
        }
    }
}
