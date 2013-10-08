using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelScout.Common;

namespace ExcelScout.ViewModel 
{
    class ExampleViewModel : NotifyPropertyChangedBase
    {
        private string _FavoriteColor;
        public string FavoriteColor 
        {
            get
            {
                return _FavoriteColor;
            }
            set
            {
                _FavoriteColor = value;
                NotifyPropertyChanged("FavoriteColor");
            }
        }
    }
}
