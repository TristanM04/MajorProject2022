﻿using System;
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
using System.Windows.Controls.Primitives;

namespace MajorProject2022
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Window
    {
        public MainPage()
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

        private void Workout_MouseLeave(object sender, MouseEventArgs e)
        {

        }

        private void Workout_MouseEnter(object sender, MouseEventArgs e)
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
    }
}
