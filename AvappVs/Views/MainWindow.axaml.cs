using Avalonia.Controls;
using Avalonia.Interactivity;
using System.Diagnostics;
using System;

namespace AvappVs.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void ClickHandler(object sender, RoutedEventArgs args)
        {
            Debug.WriteLine($"Click! Celsius={celsius.Text}");

            if (Double.TryParse(celsius.Text, out double c))
            {
                var f = c * (9d / 5d) + 32;
                fahrenheit.Text = f.ToString("0.0");
            }
            else
            {
                celsius.Text = "0";
                fahrenheit.Text = "0";
            }

            Debug.WriteLine("Click!");
            msg.Text = "Button clicked!";
        }

    }
}