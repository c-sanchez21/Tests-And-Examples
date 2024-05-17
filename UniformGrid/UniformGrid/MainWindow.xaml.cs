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

namespace UniformGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public ObservableCollection<string> Days { get; set; } = new ObservableCollection<string>(new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" });
        public MainWindow()
        {
            InitializeComponent();
            InitGrid();
            DataContext = this;
        }

        private void InitGrid()
        {

            DateTime date = DateTime.Today;
            DateTime firstOfMonth = new DateTime(date.Year, date.Month, 1);

            int dow = (int)firstOfMonth.DayOfWeek;
            for (int i = 0; i < dow; i++)
                uniGrid.Children.Add(new Label());

            for (int i = 1; i <=  DateTime.DaysInMonth(date.Year, date.Month); i++)
                uniGrid.Children.Add(new Label() { Content = i.ToString() });                
        }
    }
}