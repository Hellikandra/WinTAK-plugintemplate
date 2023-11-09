using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Composition;
using System.Windows.Input;
using WinTak.Framework.Docking;
using WinTak.Framework.Docking.Attributes;

namespace plugintemplate
{
    [DockPane(ID, "Template", Content = typeof(TemplateView))]
    internal class TemplateDockPane : DockPane
    {
        private int _counter;
        internal const string ID = "Template_TemplateDockPane";

        public TemplateDockPane()
        {
            var command = new ExecutedCommand();
            command.Executed += OnCommandExecuted;
            IncreaseCounterCommand = command;
        }

        public ICommand IncreaseCounterCommand { get; private set; }
        public int Counter
        {
            get { return _counter; }
            set { SetProperty(ref _counter, value); }
        }

        private void OnCommandExecuted(object sender, EventArgs e)
        {
            Counter++;
        }

        private class ExecutedCommand : ICommand
        {
            public event EventHandler CanExecuteChanged;

            public event EventHandler Executed;

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                var handler = Executed;
                if (handler != null)
                {
                    handler(this, EventArgs.Empty);
                }
            }
        }
    }
}
