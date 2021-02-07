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

namespace InfragisticsDataGridSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            var list = new List<Person>
            {
                new Person{ Id = 1, Name = "kaki104", Age = 11, Sex = true},
                new Person{ Id = 2, Name = "kaki105", Age = 22, Sex = false},
                new Person{ Id = 3, Name = "kaki106", Age = 33, Sex = true},
                new Person{ Id = 4, Name = "kaki107", Age = 44, Sex = false},
                new Person{ Id = 5, Name = "kaki108", Age = 55, Sex = true},
                new Person{ Id = 6, Name = "kaki109", Age = 66, Sex = false},
                new Person{ Id = 7, Name = "kaki100", Age = 77, Sex = true},
                new Person{ Id = 8, Name = "kaki101", Age = 88, Sex = false},
                new Person{ Id = 9, Name = "kaki102", Age = 99, Sex = true},
            };
            xamDataGrid.DataSource = list;
        }
    }
}
