using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.Composition;
using Prism.Events;
using Prism.Mef.Modularity;
using Prism.Modularity;

namespace plugintemplate
{
    [ModuleExport(typeof(TemplateModule), InitializationMode = InitializationMode.WhenAvailable)]
    internal class TemplateModule : IModule
    {
        private readonly IEventAggregator _eventAggregator;

        [ImportingConstructor]
        public TemplateModule(IEventAggregator evenAggregator)
        {
            _eventAggregator = evenAggregator;
        }
        // Modules will be initialized during startup. Any work that needs to be done at startup can
        // be initiated from here.
        public void Initialize()
        {

        }
    }
}
