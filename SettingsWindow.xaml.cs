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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
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

        private void Workout_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Workout_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Chat_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Chat_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Settings_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Settings_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TitleBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox TitleBox = sender as TextBox;
            if (TitleBox.Text == "Title")
                TitleBox.Text = string.Empty;
        }

        private void DescriptionBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox descripBox = sender as TextBox;
            if (descripBox.Text == "Description")
                descripBox.Text = string.Empty;
        }

        private void DurationBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Title")
                txtBox.Text = string.Empty;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Workout_Click(object sender, RoutedEventArgs e)
        {
            TestHomePage workout = new TestHomePage();
            workout.Show();
            Close();
        }

        private void EmailBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            TextBox EmailBox = sender as TextBox;
            if (EmailBox.Text == "Title")
                EmailBox.Text = string.Empty;
        }

        private void UsernameBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }

        private void PasswordBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {

        }
    }
}
