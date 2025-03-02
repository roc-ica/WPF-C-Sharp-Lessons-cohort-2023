using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;

namespace WPF_C_Sharp_Lesson_2
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cart_Window_Click(object sender, RoutedEventArgs e)
        {
            CartWindow cartWindow = new CartWindow();
            cartWindow.Show();
        }

        private void Binding_Window_Click(object sender, RoutedEventArgs e)
        {
             SimpleBindingWindow simpleBindingWindow = new SimpleBindingWindow();
            simpleBindingWindow.Show();
        }

        private void Counter_Window_Click(object sender, RoutedEventArgs e)
        {
            RealTimeCounterWindow counterWindow = new RealTimeCounterWindow();
            counterWindow.Show();
        }
    }
}