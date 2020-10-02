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
    /// Логика взаимодействия для EditDataControl.xaml
    /// </summary>
    public partial class EditDataToolBar : UserControl
    {
        private EditDataControl uc1;// = new EditDataControl();

        public EditDataToolBar()
        {
           
            InitializeComponent();

        }

        public event RoutedEventHandler AddClick;
        public event RoutedEventHandler ChangeClick;
        public event RoutedEventHandler DeleteClick;

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ChangeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Изменить");
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
        }
    }
}
