/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System.ComponentModel;
using ICheck.Interfaces.IServices;
using System.Runtime.CompilerServices;

namespace ICheck.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected INavigationService _iNavigationService;

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
