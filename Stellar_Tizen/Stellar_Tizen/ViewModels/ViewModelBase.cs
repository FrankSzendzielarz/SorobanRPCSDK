

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Stellar_Tizen.ViewModels
{
  
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region properties


        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region methods

    
        protected bool SetProperty<T>(ref T storage, T value,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

      
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
