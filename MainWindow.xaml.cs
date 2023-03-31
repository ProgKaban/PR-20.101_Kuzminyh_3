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
using PR_20._101_Kuzminyh_3.Entity;

namespace PR_20._101_Kuzminyh_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void LoadForm(int IdDiscipline)
        {
            // поиск в базе дисциплин по заданному идентификатору
            var dbContext = new Entities();
            var disciplines = dbContext.Discipline
            .Where(d => d.IdDiscipline == IdDiscipline)
            .OrderByDescending(d => d.IdDiscipline)
            .ToList();

            // если найдены дисциплины
            if (disciplines.Any())
            {
                LoadData.ItemsSource = disciplines;
            }
            // если не найдены дисциплины
            else
            {
                MessageBox.Show("Дисциплины с заданным идентификатором не найдены");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //отправляем название группы и делаем проверку через try catch
            try
            {
                LoadForm(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

   

        private void DataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
