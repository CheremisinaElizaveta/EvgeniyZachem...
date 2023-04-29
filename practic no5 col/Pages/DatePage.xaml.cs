using System;
using practic_no5_col.Models;
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
using budget_accounting;

namespace practic_no5_col.Pages
{
    /// <summary>
    /// Логика взаимодействия для DatePage.xaml
    /// </summary>
    public partial class DatePage : Page
    {
        DateTime date; 
     // DateExercises dateExercises;
        string[] months = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"};
        public DatePage(DateTime date)
        {
            InitializeComponent();
            this.date = date;
            DateExercises dateExercises;

            if (!DateExercises.data.ContainsKey(date)) 
            { 
                List<Exercise> exercises = new List<Exercise>();
                exercises.Add(new Exercise("Бургер", "Burger.png", false));
                exercises.Add(new Exercise("Пицца", "Pizza.png", false));
                exercises.Add(new Exercise("Суп", "Soup.png", false));

                dateExercises = new DateExercises(this.date, exercises);
                DateExercises.data.Add(this.date, dateExercises);  
            }
            else
                dateExercises = DateExercises.data[date];


            ExercisesListView.ItemsSource = dateExercises.Exercises;
            DateLabel.Content = $"{date.Day} {months[date.Month - 1]} {date.Year}";
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {

            DateExercises curDE = DateExercises.data[date];
            PageNavigation.MainFrame.Navigate(new MainPage());
            Json.Ser(DateExercises.data);
        }

        private void UseCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            DateExercises curDE = DateExercises.data[date];
            CheckBox box = (CheckBox)sender;
            if (curDE.frontFood == null)
                curDE.frontFood = box.DataContext as Exercise;
        }

        private void UseCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            DateExercises curDE = DateExercises.data[date];
            CheckBox box = (CheckBox)sender;
            bool found = false;
            bool needCheck = false;

            if (curDE.frontFood != null && curDE.frontFood.Name == (box.DataContext as Exercise).Name)
            {
                needCheck = true;
                foreach (Exercise exercise in curDE.Exercises)
                {
                    if (exercise.IsChecked && exercise != curDE.frontFood)
                    {
                        curDE.frontFood = exercise;
                        found = true;
                        break;
                    }
                }
            }
            if (!found && needCheck)
            {
                curDE.frontFood = null;
            }

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DateExercises.data = Json.Des<Dictionary<DateTime, DateExercises>>();
            PageNavigation.MainFrame.Navigate(new MainPage());

        }
    }
}
