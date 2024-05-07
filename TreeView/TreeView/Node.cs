using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeView
{
    public class Node
    {
        public string Name { get; set; }

        //NOTE: SubNodes must be an ObservableCollection to be able to display real time changes.
        public ObservableCollection<Node> SubNodes { get; set; } = new ObservableCollection<Node>();

        public override string ToString()
        {
            return Name;
        }
    }
}
