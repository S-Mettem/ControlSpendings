using System.ComponentModel;

namespace ControlSpendings.ViewsModels.Base
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
