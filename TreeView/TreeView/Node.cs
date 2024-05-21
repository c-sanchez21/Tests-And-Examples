using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    public class Node : INotifyPropertyChanged
    {

        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Properties
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }

        //NOTE: SubNodes must be an ObservableCollection to be able to display real time changes.        
        public ObservableCollection<Node> SubNodes { get; set; } = new ObservableCollection<Node>();
        public int TotalSubNodesCount
        {
            get
            {
                int count = SubNodes.Count;
                foreach (Node sub in SubNodes)
                    count += sub.TotalSubNodesCount;
                return count;
            }
        }
        #endregion

        #region Constructors
        public Node()
        {
            SubNodes.CollectionChanged += SubNodes_CollectionChanged;
        }
        public Node(string name) :
            this()
        {
            this.Name = name;
        }
        #endregion

        #region Methods
        private void SubNodes_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("TotalSubNodesCount");            
        }

        public override string ToString()
        {
            return Name;            
        }
        #endregion
    }
}
