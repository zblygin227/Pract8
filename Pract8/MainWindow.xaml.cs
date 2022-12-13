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

namespace Pract8
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
        GeometricProgression firstProgression;
        GeometricProgression secondProgression;

        private void Отчистить_Click(object sender, RoutedEventArgs e)
        {
            inputFirstValue1.Clear();
            inputSecondValue1.Clear();
            inputFirstValue2.Clear();
            inputSecondValue2.Clear();
        }

        private void Выход_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void О_Программе_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Создать интерфейс – серия чисел (см. лекцию). " +
                "Создать класс – геометрическая прогрессия. Класс должен включать конструктор. " +
                "Сравнение производить по шагу прогрессии.");
        }

        private void Сравнить_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int result = firstProgression.CompareTo(secondProgression);//обращаемся к методу сравнения, и сравниваем шаг первой прогрессии с шагом второй
                if (result == 0) MessageBox.Show("Шаги одинаковые");
                else if (result > 0) MessageBox.Show("Шаг первой прогрессии больше второй.");
                else if (result < 0) MessageBox.Show("Шаг второй прогрессии больше первой.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Создать_Первую_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstValue=int.Parse(inputFirstValue1.Text);//первое значение записываем в текст бокс
                int secondValue=int.Parse(inputSecondValue1.Text);//второе значение записываем в текст бокс
                firstProgression = new(firstValue, secondValue);//создаем первую прогрессию
                MessageBox.Show("Прогрессия 1 создана");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Создать_Вторую_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int firstValue = int.Parse(inputFirstValue2.Text);// первое значение записываем в текст бокс
                int secondValue = int.Parse(inputSecondValue2.Text);//второе значение записываем в текст бокс
                secondProgression = new(firstValue, secondValue);//создаем вторую прогрессию
                MessageBox.Show("Прогрессия 2 создана");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }   
}
