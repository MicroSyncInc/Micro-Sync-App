using System;
using System.Collections.Generic;
using System.Text;

namespace MicroSync.Plugins
{

    class PluginTest : IPlugin
    {
        public string Name { get => "Plugin Example"; set => throw new NotImplementedException(); }
        
        public string Version { get => "1.0.0"; set => throw new NotImplementedException(); }
        public string Author { get => "Lincoln"; set => throw new NotImplementedException(); }
        public string ID { get => "0000"; set => throw new NotImplementedException(); }

        public void Do()
        {
            
        }
    }
}
