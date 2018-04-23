using System;
using System.Linq;
using System.Windows;
using EventToCommandExample.ViewModels;

namespace EventToCommandExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainViewModel();
        }
    }
}
