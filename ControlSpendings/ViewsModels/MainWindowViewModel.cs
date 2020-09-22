using ControlSpendings.ViewsModels.Base;
using System;
using System.Runtime.CompilerServices;

namespace ControlSpendings.ViewsModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна 
        
        /// <summary> Заголовок окна </summary>
        private string _Title;

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion
    }
}
