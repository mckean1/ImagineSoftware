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

namespace ImagineSoftware
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TextBlockDescription.Text = "ImagineSoftware is a leading provider of medical billing, revenue cycle, and practice management software";
                LabelNextKey.Content = "Exit";
            }

            else if (e.Key == Key.Escape)
            {
                TextBlockDescription.Text = "Hit the Enter Key";
                LabelNextKey.Content = "Enter";
            }
        }
    }
}
