using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FunnyVodovoz
{
    /// <summary>
    /// Описывает сущность - Подразделение
    /// </summary>
    class Department : INotifyPropertyChanged
    {
        /// <summary>
        /// Код подразделения
        /// </summary>
        private int departmentId;

        /// <summary>
        /// Название подразделения
        /// </summary>
        private string name;

        /// <summary>
        /// ID начальника
        /// </summary>
        private int cheifId;

        public int DepartmentId
        {
            get { return departmentId; }
            set
            {
                departmentId = value;
                OnPropertyChanged("DepartmentId");
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int CheifId
        {
            get { return cheifId; }
            set
            {
                cheifId = value;
                OnPropertyChanged("CheifId");
            }
        }



        //----------------------------------------------------------------------------------------------------
        /// <summary>
        /// Обработчик собития изменения свойств класса
        /// </summary>

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }
}
