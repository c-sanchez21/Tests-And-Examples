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
        public event PropertyChangedEventHandler? PropertyChanged;
        public Node()
        {
            SubNodes.CollectionChanged += SubNodes_CollectionChanged;
        }        

        public string Name { get; set; }

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

        private void SubNodes_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged("TotalSubNodesCount");            
        }

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public override string ToString()
        {
            return Name;            
        }
    }
}
