using Syncfusion.WinForms.DataGrid;
using System;
using System.Windows.Forms;
using Syncfusion.Data;
using System.Collections.Generic;
using Syncfusion.DataSource;

public class MainForm : Form
{
    private SfDataGrid dataGrid;

    public MainForm()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        dataGrid = new SfDataGrid();
        dataGrid.Dock = DockStyle.Fill;

        List<Employee> employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "John Doe", Age = 28 },
            new Employee { ID = 2, Name = "Jane Smith", Age = 34 },
            new Employee { ID = 3, Name = "Samuel Adams", Age = 40 },
            new Employee { ID = 4, Name = "Nancy Green", Age = 22 }
        };

        dataGrid.DataSource = employees;
        dataGrid.SortDescriptors.Add(new SortDescriptor { Column = "Age", Direction = ListSortDirection.Ascending });
        dataGrid.FilterDescriptors.Add(new FilterDescriptor { Column = "Age", FilterType = FilterType.GreaterThan, Value = 30 });

        Controls.Add(dataGrid);
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}