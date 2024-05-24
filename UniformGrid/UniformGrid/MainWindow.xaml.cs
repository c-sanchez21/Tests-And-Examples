using System.Collections.ObjectModel;
using System.Diagnostics;
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
    /// Experimenting with Uniform Grids
    /// </summary>
    public partial class MainWindow : Window
    {
        
        #region Properties
        /// <summary>
        /// Day of the Week strings
        /// </summary>
        public ObservableCollection<string> DayOfWeek { get; set; } = new ObservableCollection<string>(new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" });
        public ObservableCollection<string> Days { get; set; } = new ObservableCollection<string>();
        public string Month
        {
            get
            {
                return DateTime.Now.ToString("MMMM");
            }
        }
        #endregion

        #region Constructors
        public MainWindow()
        {
            InitializeComponent();
            InitDays();
            DataContext = this;
        }
        #endregion

        #region Methods
        private void InitDays()
        {
            DateTime date = DateTime.Today;
            DateTime firstOfMonth = new DateTime(date.Year, date.Month, 1);
            
            int dow = (int)firstOfMonth.DayOfWeek;
            Days = new ObservableCollection<string>();
            for (int i = 0; i < dow; i++)
                Days.Add("");            

            for (int i = 1; i <= DateTime.DaysInMonth(date.Year, date.Month); i++)
                Days.Add(i.ToString());                
        }
        #endregion
    }
}