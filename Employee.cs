using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DzModul5
{
    public class Employee
    {
        private string name;
        private string position;
        private decimal salary;

        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(); // Уведомление системы от изменении свойства
                }
            }
        }
        public string Position
        {
            get => position;
            set
            {
                if (position != value)
                {
                    position = value;
                    OnPropertyChanged(); // Уведомление системы от изменении свойства
                }

            }
        }
        public decimal Salary
        {
            get => salary;
            set
            {
                if (salary != value)
                {
                    salary = value;
                    OnPropertyChanged(); // Уведомление системы от изменении свойства
                }

            }
        }

        public Employee(string nameP, string positionP, decimal salaryP)
        {
            this.name = nameP;
            this.position = positionP;
            this.salary = salaryP;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"{Name}-{Position}-{Salary}";
        }
    }


    
}
