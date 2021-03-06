using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace WorkTimeManager.Models
{
    abstract class Model : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
