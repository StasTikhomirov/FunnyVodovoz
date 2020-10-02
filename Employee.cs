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
    /// Описывает сущность - Сотрудник
    /// </summary>
    class Employee : INotifyPropertyChanged
    {
        /// <summary>
        /// Id сотрудника
        /// </summary>
        private int employeeId;

        /// <summary>
        /// Фамилия
        /// </summary>
        private string surName;

        /// <summary>
        /// Имя
        /// </summary>
        private string name;

        /// <summary>
        /// Отчество
        /// </summary>
        private string patronymic;

        /// <summary>
        /// Дата рождения
        /// </summary>
        private DateTime birthday;

        /// <summary>
        /// Пол
        /// </summary>
        private GenderEnum gender;

        /// <summary>
        /// Код подразделения
        /// </summary>
        private int departmentId;

        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                employeeId = value;
                OnPropertyChanged("EmployeeId");
            }
        }

        public string SurName
        {
            get { return surName; }
            set
            {
                surName = value;
                OnPropertyChanged("SurName");
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

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                birthday = value;
                OnPropertyChanged("Birthday");
            }
        }

        public GenderEnum Gender
        {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged("Gender");
            }
        }
        
        public int DepartmentId
        {
            get { return departmentId; }
            set
            {
                departmentId = value;
                OnPropertyChanged("DepartmentId");
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


    /// <summary>
    /// Описывает перечисление возможных Полов сотрудников
    /// </summary>
    enum GenderEnum { male, female }
}

