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

namespace TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Note: ObservableCollection must be a public property {i.e have get; set;} to enable binding. 
        public ObservableCollection<Node> Nodes { get; set; } = new ObservableCollection<Node>();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            InitializeNodes();
        }

        private void InitializeNodes()
        {
            //Nodes = new ObservableCollection<Node>();
            Node root = new Node() { Name = "Root" };
            Node child1 = new Node() { Name = "Child A" };
            child1.SubNodes.Add(new Node() { Name = "Grandchild A1" });
            child1.SubNodes.Add(new Node() { Name = "Grandchild A2" });
            Node child2 = new Node() { Name = "Child B" };
            child2.SubNodes.Add(new Node() { Name = "Grandchild B1" });
            child2.SubNodes.Add(new Node() { Name = "Grandchild B2" });
            root.SubNodes.Add(child1);
            root.SubNodes.Add(child2);
            Nodes.Add(root);
        }
        
        private void btnAddChildren_Click(object sender, RoutedEventArgs e)
        {
            if (Nodes == null) return;

            Node n = tvNodes.SelectedItem as Node;
            if (n == null)
            {
                MessageBox.Show("No node selected.");
                return;
            }
            n.SubNodes.Add(new Node() { Name = txtName.Text });

            /*
            if (Nodes.Count > 0)
            {
                Node sub = Nodes[Nodes.Count - 1];
                sub.SubNodes.Add(new Node() { Name = $"Child {sub.SubNodes.Count + 1}" });
                sub.Name += "(Added Noded)";
            }
                                                        
            Nodes.Add(new Node() { Name= $"Root {Nodes.Count+1}"});
            */
        }
    }
}