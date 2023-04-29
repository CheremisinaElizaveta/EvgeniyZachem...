using practic_no5_col.UserControls;
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

namespace practic_no5_col.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        DateTime currentdate = DateTime.Today;
        string[] months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
        public MainPage()
        {
            InitializeComponent();
      
            UpdateCurrentDate();
        }

        private void CalendarButton_Click(object sender, RoutedEventArgs e)
        {
            if (Calendar.Visibility == Visibility.Hidden)
            {
                Calendar.Visibility = Visibility.Visible;
            }
            else
            {
                Calendar.Visibility = Visibility.Hidden;
            }
        }

        private void PreviousButton_Click(object sender, RoutedEventArgs e)
        {
            currentdate = currentdate.AddMonths(-1);
            UpdateCurrentDate();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            currentdate = currentdate.AddMonths(1);
            UpdateCurrentDate();
        }

        private void UpdateCurrentDate()
        {
            MonthLable.Content = $"{months[currentdate.Month - 1]} {currentdate.Year}";
            Calendar.SelectedDate = currentdate;
            Calendar.DisplayDate = currentdate;
            DayWrapPanel.Children.Clear();
            for (int i = 1; i <= DateTime.DaysInMonth(currentdate.Year, currentdate.Month); i++)
            {
                DayWrapPanel.Children.Add(new DateUserConrol(new DateTime(currentdate.Year, currentdate.Month, i)));
            }
        }

        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            currentdate = Calendar.SelectedDate.Value;
            UpdateCurrentDate();
        }
    }
}
