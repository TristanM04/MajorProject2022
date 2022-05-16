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

        //I have finished working out which versions for all the packages I need to work on for this project and created the correct solution
        //STEP 1: CHECK IF I CAN ACCESS THE SQL DATABASE
        //STEP 2: CREATE THE WPF USER INTERFACE
        //STEP 3: CORRESPOND THE INTERFACE BUTTONS WITH BACKEND METHODS AND CLASSES

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
        
        public void GrantAccess()
        {
            MainPage main = new MainPage();
            main.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var UserName = UsernameBox.Text;
            var PassWord = PasswordBox.Password;

            using (UserDataContext context = new UserDataContext())
            {
                bool userfound = context.Users.Any(user => user.Name == UserName && user.Password == PassWord);

                if (userfound)
                {
                    GrantAccess();
                    Close();
                } else
                {
                    MessageBox.Show("User Not Found");
                }
            }
        }
    }
}
