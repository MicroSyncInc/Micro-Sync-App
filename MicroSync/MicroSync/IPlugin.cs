using System;
using System.Collections.Generic;
using System.Text;

namespace MicroSync
{
    public interface IPlugin
    {
        string Name { get; set; }
        string ID { get; set; }
        string Version { get; set; }
        string Author { get; set; }
    }
}
