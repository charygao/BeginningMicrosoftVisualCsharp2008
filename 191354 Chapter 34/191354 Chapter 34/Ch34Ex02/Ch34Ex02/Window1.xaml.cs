using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Ch34Ex02
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private void Generic_MouseDown(object sender, MouseButtonEventArgs e)
        {
            outputText.Text = string.Format(
                "{0}Event {1} raised by control {2}. e.Source={3}\n",
                outputText.Text,
                e.RoutedEvent.Name,
                sender.ToString(),
                ((FrameworkElement)e.Source).Name);
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            outputText.Text = string.Format(
                "{0}==========\n\n",
                outputText.Text);
        }

        private void clickMeButton_Click(object sender, RoutedEventArgs e)
        {
            outputText.Text = string.Format(
                "{0}Button clicked!\n==========\n\n",
                outputText.Text);
        }
    }
}
