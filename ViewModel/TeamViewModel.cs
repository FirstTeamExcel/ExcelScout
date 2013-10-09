using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelScout.Common;
namespace ExcelScout.ViewModel
{
    class TeamViewModel:NotifyPropertyChangedBase
    {
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                NotifyPropertyChanged("Name");
                NotifyPropertyChanged("TeamTitle");
            }
        }
        private int _Number;
        public int Number
        {
            get
            {
                return _Number;
            }
            set
            {
                _Number = value;
                NotifyPropertyChanged("Number");
                NotifyPropertyChanged("TeamTitle");
            }
        }

        public string TeamTitle
        {
            get
            {
                return string.Format("Team {1} Number {0}", Number, Name);
            }
        }
    }
}
