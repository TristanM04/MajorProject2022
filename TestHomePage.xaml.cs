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

namespace MajorProject2022
{
    /// <summary>
    /// Interaction logic for TestHomePage.xaml
    /// </summary>
    public partial class TestHomePage : Window
    {
        public List<Workout> DatabaseWorkouts { get; private set; }

        public TestHomePage()
        {
            InitializeComponent();
            Read();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) //Allows the windoes to be dragged around, allows accesibility
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Workout_MouseLeave(object sender, MouseEventArgs e)
        {

        } // This makes the button glow up when the user hovers over it

        private void Workout_MouseEnter(object sender, MouseEventArgs e)  // This makes the button glow up when the user hovers over it
        {

        }

        private void Chat_MouseEnter(object sender, MouseEventArgs e)
        {

        } // This makes the button glow up when the user hovers over it

        private void Chat_MouseLeave(object sender, MouseEventArgs e)
        {

        } // This makes the button glow up when the user hovers over it

        private void Settings_MouseEnter(object sender, MouseEventArgs e) // This makes the button glow up when the user hovers over it
        {

        }

        private void Settings_MouseLeave(object sender, MouseEventArgs e)
        {

        } // This makes the button glow up when the user hovers over it

        private void Exit_Click(object sender, RoutedEventArgs e) // Exit button
        {
            Close();
        }

        private void AddWorkOutBtn_Click(object sender, RoutedEventArgs e) // The button to add a workout
        {
            using (UserDataContext context = new UserDataContext())
            {

                DateTime myDate = DateTime.Now; //Retrieves time
                string DateString = myDate.ToString("dd/MM/yyyy"); //Saves date with each workout
                var title = TitleBox.Text;
                var description = DescriptionBox.Text;
                var duration = DurationBox.Text;
                if (title != null && description != null && duration != null)  //Make sure all fields are filled
                {
                    if (duration.Any(c => Char.IsLetter(c))) //Makes sure an exception isn't thrown when the user tries to enter a letter for a duration
                    {
                        MessageBox.Show("Duration must be an integer");
                    } else
                    {
                        context.Workouts.Add(new Workout() { Title = title, Description = description, Duration = duration, UserID = Globals.primaryKey, Date = DateString}); //If it doesnt exist, then create the user
                        context.SaveChanges(); //saves changes to the database
                        MessageBox.Show("Created workout!");
                    }
                } else
                {
                    MessageBox.Show("Fill all fields");
                }
            }
        }

        private void TitleBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the title box
        {
            TextBox TitleBox = sender as TextBox;
            if (TitleBox.Text == "Title")
                TitleBox.Text = string.Empty;
        }

        private void DescriptionBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the description box
        {
            TextBox descripBox = sender as TextBox;
            if (descripBox.Text == "Description")
                descripBox.Text = string.Empty;
        }

        private void DurationBox_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e) //This makes the text invisible when the user clicks on the duration box
        {
            TextBox txtBox = sender as TextBox;
            if (txtBox.Text == "Duration(min)")
                txtBox.Text = string.Empty;
        }

        
        public void Read()
        {
            using (UserDataContext context = new UserDataContext())
            {
                decimal total = 0;
                var userWorkouts = context.Workouts.Where(w => w.UserID == Globals.primaryKey).ToList(); //Where the workout has the userId of the user that is logged in, save it to the 'userWorkouts'

                ItemList.ItemsSource = userWorkouts; //Make userWorkouts the list for the view

                foreach (Workout item in ItemList.ItemsSource)
                {
                    total += Convert.ToDecimal(item.Duration); //Calculates the amount of time the user has added
                }
                string totalhours = "Total minutes: ";
                var finalValue = totalhours + total;
                Totaltext.Text = finalValue;

            }


        } //Reads from the database and displays in a list view


        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settings = new SettingsWindow();
            settings.Show();
            Close();
        } //Click to go to settings page

        private void RefreshBtn_Click(object sender, RoutedEventArgs e) //Refreshes the table and window
        {
            Read();
        }
    }
}
