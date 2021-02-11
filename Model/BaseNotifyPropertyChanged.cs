using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_de_Pessoas.Model
{
    public abstract class BaseNotifyPropertyChanged : System.ComponentModel.INotifyPropertyChanged // To send some notifys when a property has changed
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void SetField<T>(ref T field, T value, [System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            if (!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                RaisePropertyChanged(propertyName);
            }
        }
        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
        }
    }
}
