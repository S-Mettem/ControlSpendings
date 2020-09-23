using ControlSpendings.Infrastructure.Commands;
using ControlSpendings.ViewsModels.Base;
using System;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace ControlSpendings.ViewsModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок окна 

        /// <summary> Заголовок окна </summary>
        private string _Title = "Главное окно - ControlS";

        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Commands

        #region CloseApplicationCommand

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p) => Application.Current.Shutdown();
        private bool CanCloseApplicationCommandExecute(object p) => true;
        #endregion

        #endregion

        public MainWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new ActionCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion


        }
    }
}
