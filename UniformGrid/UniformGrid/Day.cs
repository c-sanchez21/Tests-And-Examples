using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace UniformGrid
{
    public class Day : INotifyPropertyChanged
    {
        #region Events
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region Properties
        public DateTime? Date { get; set; }        
        public bool IsToday { get { return Date == DateTime.Today; } }
        #endregion

        #region Constructors
        public Day() { }
        public Day(DateTime d) :
            this()
        { 
            this.Date = d;
        }
        #endregion

        #region Methods
        public override string ToString()
        {            
            return Date?.ToString("dd");
        }
        #endregion

    }
}
