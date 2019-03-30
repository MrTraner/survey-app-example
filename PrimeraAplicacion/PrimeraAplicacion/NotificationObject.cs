using System;
using System.Collections.Generic;
using System.Text;

using System.ComponentModel; //Para usar INotififyPropertyChanged
using System.Runtime.CompilerServices; //Para usar CallerMemberName

namespace PrimeraAplicacion
{
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
