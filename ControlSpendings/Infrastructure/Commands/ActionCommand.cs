using ControlSpendings.Infrastructures.Commands.Base;
using System;
using System.Buffers.Text;

namespace ControlSpendings.Infrastructure.Commands
{
    internal class ActionCommand : Command
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;
        public ActionCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public Action<object> Execute1 { get; }
        public Func<object, bool> CanExecute1 { get; }

        public override bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object parameter) => _Execute(parameter);
    }
}
