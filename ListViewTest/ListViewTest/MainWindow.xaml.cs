using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListViewTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            People.Add(new Person() { Name = "A", Age = 10 });
            People.Add(new Person() { Name = "B", Age = 20 });
            People.Add(new Person() { Name = "C", Age = 30 });
        }
    }
}