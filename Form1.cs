using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DzModul5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            BindingList<Employee> employees = new BindingList<Employee>()
            {
            new Employee("Иванов Иван Павлович", "Профессор", 50000),
            new Employee("Михайлов Никита Андреевич", "Преподователь", 35000),
            new Employee("Полякова Инна Николаевна", "Преподователь", 35000),
            new Employee("Никитин Андрей Иванович", "Стажер", 15000),
            };

            listBoxEmployee.DataSource = employees;
            //listBoxEmployee.DisplayMember = "Name";
            textBoxName.DataBindings.Add(new Binding("Text", this, "SelectedEmployee.Name", false, DataSourceUpdateMode.OnPropertyChanged));
            textBoxPosition.DataBindings.Add(new Binding("Text", this, "SelectedEmployee.Position", false, DataSourceUpdateMode.OnPropertyChanged));
            numericUpDownSalary.DataBindings.Add(new Binding("Text", this, "SelectedEmployee.Salary", false, DataSourceUpdateMode.OnPropertyChanged));


            listBoxEmployee.DataBindings.Add(new Binding("SelectedItem", this, "SelectedEmployee", false, DataSourceUpdateMode.OnPropertyChanged));
         }

        public Employee SelectedEmployee
        {
            get => listBoxEmployee.SelectedItem as Employee;
            set
            {
                if (value != listBoxEmployee.SelectedItem)
                {
                    listBoxEmployee.SelectedItem = value;
                }
            }
        }
        private void listBoxEmlpoyee_SelectIndexChenged(object sender, EventArgs e)
        {
            if(listBoxEmployee.SelectedItem is Employee selectEmployee)
            {
                textBoxName.Text = selectEmployee.Name;
                textBoxPosition.Text = selectEmployee.Position;
                numericUpDownSalary.Value = selectEmployee.Salary;
            }
        }
        
    }
}
