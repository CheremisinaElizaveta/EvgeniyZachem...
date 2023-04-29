using practic_no5_col.Models;
using practic_no5_col.Pages;
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

namespace practic_no5_col.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DateUserConrol.xaml
    /// </summary>
    public partial class DateUserConrol : UserControl
    {
        DateTime date;
        public DateUserConrol(DateTime date)
        {
            InitializeComponent();

            this.date = date;
            DateExercises dateExercises;
            DayLabel.Content = date.Day;

            if (DateExercises.data.ContainsKey(date))
            {
                dateExercises = DateExercises.data[date];
                ImageSourceConverter isc = new ImageSourceConverter();
                string imagePath = $"D:\\ПРАКТОС УЖЕ ВОТ ПЯТЫЙ\\practic no5 col\\practic no5 col\\Resoucres\\Ellipsis.png";

                if (dateExercises.frontFood != null)
                    imagePath = dateExercises.frontFood.ImagePath;

                DayImage.Source = (ImageSource) isc.ConvertFrom(imagePath);
            }
        }

        private void UserControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            PageNavigation.MainFrame.Navigate(new DatePage(date));
        }
    }
}
