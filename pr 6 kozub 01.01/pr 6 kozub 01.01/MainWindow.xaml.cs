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

namespace pr_6_kozub_01._01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Man firstHuman = new();
        private Man secondHuman = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5\n" +
                "Козуб Дмитрий ИСП-34\n" +
                "Создать класс Man (человек), с полями: имя, возраст, пол и вес. Создать необходимые методы и свойства." +
                "Создать перегруженные методы SetParams, для установки параметров человека.", "О программе", MessageBoxButton.OK);
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void createFirstHuman_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = inputFirstName.Text;
                int age = Convert.ToInt32(inputFirstAge.Text);
                char sex = Convert.ToChar(inputFirstSex.Text);
                int weight = Convert.ToInt32(inputFirstWeight.Text);
                firstHuman.SetParams(name, sex, age, weight);
                MessageBox.Show("Человек с заданными параметрами создан", "Успех");
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Возраст не может быть отрицательным", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void createSecondHuman_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = inputSecondName.Text;
                int age = Convert.ToInt32(inputSecondAge.Text);
                char sex = Convert.ToChar(inputSecondSex.Text);
                int weight = Convert.ToInt32(inputSecondWeight.Text);
                secondHuman.SetParams(name, sex, age, weight);
                MessageBox.Show("Человек с заданными параметрами создан", "Успех");
            }
            catch (ArgumentOutOfRangeException)
            {

                MessageBox.Show("Возраст не может быть отрицательным", "Ошибка");
            }
            catch
            {
                MessageBox.Show("Проверьте введенные значения", "Ошибка");
            }
        }

        private void increaseSecondAgeBy1_Click(object sender, RoutedEventArgs e)
        {
            if (secondHuman.Age != 0)
            {
                secondHuman.Age++;
                inputSecondAge.Text = secondHuman.Age.ToString();
            }
            else MessageBox.Show("Создайте человека", "Ошибка");
        }

        private void increaseFirstAgeBy1_Click(object sender, RoutedEventArgs e)
        {
            if (firstHuman.Age != 0)
            {
                firstHuman.Age++;
                inputFirstAge.Text = firstHuman.Age.ToString();
            }
            else MessageBox.Show("Создайте человека", "Ошибка");
        }

        private void compareWeights_Click(object sender, RoutedEventArgs e)
        {
            if (firstHuman.Weight != 0 || secondHuman.Weight != 0)
            {
                bool compareResult = firstHuman > secondHuman;
                if (compareResult)
                    MessageBox.Show("Первый тяжелее второго");
                if (!compareResult)
                {
                    MessageBox.Show("Второй тяжелее первого");
                }
            }
            else MessageBox.Show("Для начала создайте людей", "Ошибка");
        }
    }
}
