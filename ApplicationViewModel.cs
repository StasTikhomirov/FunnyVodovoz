using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FunnyVodovoz
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        EditDataControl u1;

        private Employee currentEmployee;
        public BindingList<Employee> Employees { get; set; }
        public Employee CurrentEmployee
        {
            get { return currentEmployee; }
            set
            {
                currentEmployee = value;
                OnPropertyChanged("CurrentEmployee");
            }
        }

        private Department currentDepartment;
        public BindingList<Department> Departments { get; set; }
        public Department CurrentDepartment
        {
            get { return currentDepartment; }
            set
            {
                currentDepartment = value;
                OnPropertyChanged("CurrentDepartment");
            }
        }

        public ApplicationViewModel()
        {
           // u1 = new EditDataControl();
            

            Employees = new BindingList<Employee>
            {
                new Employee { EmployeeId=11, SurName = "Джобс", Name ="Apple", Patronymic = "Александрович", Birthday = new DateTime(1582, 10, 5), Gender = GenderEnum.male, DepartmentId = 3 },
                new Employee { EmployeeId=17, SurName = "Не знаю", Name ="Samsung", Patronymic = "Владимирович",Birthday = new DateTime(1762, 12, 10), Gender = GenderEnum.male, DepartmentId = 2 },
                new Employee { EmployeeId=23, SurName = "Принтер", Name ="HP", Patronymic = "Петрович",Birthday = new DateTime(1992, 1, 7), Gender = GenderEnum.male, DepartmentId = 1 }               
            };

            Departments = new BindingList<Department>
            {
                new Department{DepartmentId = 1, Name="Отдел пупкина" },
                new Department { DepartmentId = 2, Name = "Отдел Головина" },
                new Department { DepartmentId = 3, Name = "Отдел по позитиву" }
            };

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}

