using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Composition;
using WinTak.Framework.Docking;
using WinTak.Framework.Tools;
using WinTak.Framework.Tools.Attributes;

namespace plugintemplate
{
    [Button("Template_TemplateButton", "Template Plugin",
    LargeImage = "pack://application:,,,/plugintemplate;component/assets/Settings.svg",
    SmallImage = "pack://application:,,,/plugintemplate;component/assets/Settings_24x24.png")]
    internal class TemplateButton : Button
    {
        private IDockingManager _dockingManager;

        [ImportingConstructor]
        public TemplateButton(IDockingManager dockingManager)
        {
            _dockingManager = dockingManager;
        }
        protected override void OnClick()
        {
            base.OnClick();

            var pane = _dockingManager.GetDockPane(TemplateDockPane.ID);
            pane?.Activate();
        }
    }
}
