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

namespace FunnyVodovoz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new ApplicationViewModel();
        }


        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Добавить");
        //}

        //private void ChangeButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Изменить");
        //}

        //private void DeleteButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Удалить");
        //}
    }
}
