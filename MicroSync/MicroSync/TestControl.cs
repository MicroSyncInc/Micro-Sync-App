using System;
using System.Collections.Generic;
using System.Text;

namespace MicroSync
{
    class TestControl : Control
    {
        public override string Name { get => "Test Control"; set => throw new NotImplementedException(); }
        public override string ID { get => "0000"; set => throw new NotImplementedException(); }
        public override string Version { get => "1.0.0"; set => throw new NotImplementedException(); }
        public override string Author { get => "Lincoln"; set => throw new NotImplementedException(); }
    }
}
