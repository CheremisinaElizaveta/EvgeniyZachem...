using budget_accounting;
using Newtonsoft.Json;
using practic_no5_col.Models;
using practic_no5_col.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practic_no5_col.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PageNavigation.MainFrame = MainFrame;
            DateExercises.data = Json.Des<Dictionary<DateTime, DateExercises>>();

            MainFrame.Navigate(new MainPage());
        }

    }
}
